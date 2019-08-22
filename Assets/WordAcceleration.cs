using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordAcceleration : MonoBehaviour
{
    public static float acceleration;

    void Start()
    {
        acceleration = 0.2f;
    }

    public float GetAcceleration()
    {
        return acceleration;
    }

    public void SetAcceleration(float _acceleration)
    {
        acceleration = _acceleration;
    }

    public void SetLevel(float level)
    {
        Debug.Log("Level " + level);

        if(acceleration < 2f)
        {
            acceleration += level / 25;
        }

        if(WordTimer.wordDelay < 0.5f)
        {
            WordTimer.wordDelay *= 0.9f;
        }
        
        Debug.Log("Velocidade: " + acceleration);



    }
}
