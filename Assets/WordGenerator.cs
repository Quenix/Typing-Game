using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{

   private static string[] wordList = {"mesmo",
        "chato",
        "teste",
        "abacate",
        "legumes",
        "sol",
        "muitos",
        "sorriso",
        "morango",
        "você",
        "louco",
        "cachorro",
        "gato",
        "batata",
        "filhote",
        "peixe"};

   public static string GetRandomWord ()
   {

       int randomIndex = Random.Range(0, wordList.Length);
       string randomWord = wordList[randomIndex];

       return randomWord;

   }
}
