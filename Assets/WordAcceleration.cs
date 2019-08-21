using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordAcceleration : MonoBehaviour
{
    public static float acceleration;

    void Start()
    {
        acceleration = 0.5f;
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
        Debug.Log("Velocidade: " + acceleration);
        acceleration *= level;

        

    }
}
