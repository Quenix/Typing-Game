using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour
{
    public Text text;
    public float fallSpeed;
    public List<Word> words;
    public Word word;

    public void SetWord (string word)
    {
        text.text = word;

    }

    public void RemoveLetter ()
    {
    
        try
        {
            text.text = text.text.Remove(0, 1);
            text.color = Color.red;
        }
        catch (Exception e)
        {

        }
    }

    public void RemoveWord ()
    {
        try
        {
            Destroy(gameObject);
        }
        catch (Exception e)
        {
            
        }
        
    }

    private void Start()
    {
        fallSpeed = 1f;
    }
    private void Update ()
    {
        transform.Translate(0f, (-fallSpeed-WordAcceleration.acceleration) * Time.deltaTime, 0f);
    }

}
