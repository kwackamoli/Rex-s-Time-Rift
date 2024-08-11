using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScreenManager : MonoBehaviour
{
    public static DeathScreenManager Instance;
public AudioSource audio;
    public GameObject player;
    public Canvas canvas;
    public AudioSource music;

    private void Awake()
    {
        audio = GetComponent <AudioSource>();
        Instance = this;
    }

    public void SetDeathMenu(bool state) 
    { 

        canvas.enabled = state;

        if (state)
        {
            Destroy(player);
            audio.Play ();
music.Pause ();
        }

    }

}
