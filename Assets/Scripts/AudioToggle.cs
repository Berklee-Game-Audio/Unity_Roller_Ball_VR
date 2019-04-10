//LMSC-281 - VR RollerBall
//Berklee College of Music
//Fall 2018 - Zack Frank
//Script to turn audio on and off when player collides with "Pickup" sphere 

using UnityEngine;
using System.Collections;

public class AudioToggle : MonoBehaviour {

    AudioSource audioSource;

    void Start() {
        audioSource = GetComponent<AudioSource>();
        // gameObject = GetComponent<PlayerController>(); 
    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Pickup") {
            audioSource.mute = !audioSource.mute;
        }
    }
    void Update() {
    }
}

//So, the script is not currently working. 
//It's adapted from a script I found on the Unity site.
//I'm going to try to fix it asap

