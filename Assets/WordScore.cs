using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordScore : MonoBehaviour
{
    public Text textScore;
    public float score;
    public WordAcceleration wordAcceleration;
    void Start()
    {
        score = 0;
        textScore.text = score.ToString();
    }

    public void IncreaseScore()
    {
        //textScore.text = score.ToString();
        score++;
        textScore.text = score.ToString();

        if(score % 10 == 0)
        {
            wordAcceleration.SetLevel(score/10);
        }
        
    }

    public float GetScore()
    {
        return score;
    }
}
