using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent <AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Random.Range(0,3000)==0){
audio.Play();
        }
    }
}
