using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private static AudioManager instance = null;
    private static AudioSource audioSrc;
    public static AudioClip hit, miss, kill, levelUp, gameOver;
    
    private static AudioManager Instance
    {
        get { return instance; }
    }

    private void Start()
    {
        hit = Resources.Load<AudioClip> ("hit");
        miss = Resources.Load<AudioClip> ("miss");
        kill = Resources.Load<AudioClip> ("kill");
        levelUp = Resources.Load<AudioClip> ("levelUp");
        //todo
        //gameOver = Resources.Load<AudioClip> ("gameOver");

        audioSrc = GetComponent<AudioSource> ();
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "hit":
                audioSrc.PlayOneShot(hit, 0.2f);
                break;
            case "miss":
                //not using it at all
                audioSrc.PlayOneShot(miss, 0.2f);
                break;
            case "kill":
                audioSrc.PlayOneShot(kill, 0.3f);
                break;
            case "levelUp":
                //still don't like this one that much
                audioSrc.PlayOneShot(levelUp, 0.4f);
                break;
            case "gameOver":
                //todo
                break;
        }
    }
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }

        DontDestroyOnLoad(this.gameObject);
    }
}
