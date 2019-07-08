using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitSoundB : MonoBehaviour {
    public AudioClip impact;
    AudioSource audioSource;
    // Use this for initialization
    void Start () {
        audioSource = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
       
    }

    public void SoundHitB() {
        audioSource.PlayOneShot(impact, 0.3f);
    }
}
