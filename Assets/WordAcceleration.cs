using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordAcceleration : MonoBehaviour
{
    public static float acceleration;

    void Start()
    {
        acceleration = 0.02f;
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

        if (acceleration < 0.5f)
        {
            //acceleration += level / 50;
        }

        if(WordTimer.wordDelay > 0.7f)
        {
            WordTimer.wordDelay *= 0.8f;
        }
        
        Debug.Log("Velocidade: " + acceleration);



    }
}
