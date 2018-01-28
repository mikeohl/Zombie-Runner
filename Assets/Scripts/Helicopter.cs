using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour {

    public AudioClip callSound;

    private bool heliCalled = false;
    //private AudioSource radio;
    private AudioSource audioSource;

	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
        //audioSource = 
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Call Helicopter") && !heliCalled)
        {
            Debug.Log("Called Helicopter");
            heliCalled = true;
            audioSource.clip = callSound;
            audioSource.Play();
        }
	}
}
