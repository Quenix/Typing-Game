using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour
{
    public List<Word> words;
    private bool hasActiveWord;
    private Word activeWord;
    public WordSpawner wordSpawner;
    public WordScore wordScore;

    public void AddWord()
    {

        Word word = new Word(WordGenerator.GetRandomWord(), wordSpawner.SpawnWord());

        words.Add(word);
    }

    public void TypeLetter (char letter)
    {
        if (hasActiveWord)
        {
            if (activeWord.GetNextLetter() == letter)
            {
                try
                {
                    activeWord.TypeLetter();
                }
                catch(Exception e)
                {
                    DesactiveWord();
                    RemoveActiveWord(activeWord);
                }
                
            }
        } else
        {
            foreach (Word word in words)
            {
                if(word.GetNextLetter() == letter)
                {
                    activeWord = word;
                    hasActiveWord = true;
                    word.TypeLetter();
                    break;
                }
            }
        }

        if (hasActiveWord && activeWord.WordTyped())
        {
            hasActiveWord = false;
            words.Remove(activeWord);
            wordScore.IncreaseScore();
        }
    
    }

    public void DesactiveWord()
    {
        hasActiveWord = false;
    }

    public Word GetActiveWord()
    {
        return activeWord;
    }

    public void RemoveActiveWord(Word _activeWord)
    {
        words.Remove(_activeWord);
    }

}
