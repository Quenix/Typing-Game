using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordTimer : MonoBehaviour
{
    public WordManager wordManager;
    public static float wordDelay;

    private float nextWordTime = 0f;

    private void Start()
    {
        wordDelay = 1.0f;
    }
    private void Update ()
    {
        if (Time.time >= nextWordTime)
        {
            wordManager.AddWord();
            nextWordTime = Time.time + wordDelay;
        }
    }
}
