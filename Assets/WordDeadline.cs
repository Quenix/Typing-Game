using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WordDeadline : MonoBehaviour
{
    public WordManager wordManager;
    
    public void OnTriggerEnter2D(Collider2D col)
    {
        wordManager.DesactiveWord();
        wordManager.RemoveActiveWord(wordManager.GetActiveWord());
        Destroy(col.gameObject);
        SceneManager.LoadScene("Game"); //Load scene called Game
    }
}
