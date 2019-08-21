using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Word
{

    public string word;
    private int typeIndex;
    private float acceleration;
    WordDisplay display;

    public Word (string _word, WordDisplay _display)
    {
        word = _word;
        typeIndex = 0;

        display = _display;
        display.SetWord(word);
    }

    public char GetNextLetter ()
    {
        return word[typeIndex];
    }

    public void TypeLetter ()
    {
        typeIndex++;
        display.RemoveLetter();
    }

    public bool WordTyped ()
    {
        try
        {
            bool wordTyped = (typeIndex >= word.Length);
            if (wordTyped)
            {
                display.RemoveWord();
            }

            return wordTyped;
        }
        catch(Exception e)
        {
            return true;
        }
    }
}
