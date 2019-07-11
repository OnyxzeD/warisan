using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class BgmController : MonoBehaviour {

    
    public AudioClip vic;
    AudioSource audio;
    

    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    public void Victory()
    {
        audio.Stop();

        audio.clip = vic;
        audio.volume = 0.3f;
        audio.Play();
    }
	
}
