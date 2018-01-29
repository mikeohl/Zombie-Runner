using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InnerVoice : MonoBehaviour {

    public AudioClip whatHappened;
    public AudioClip goodLandingZone;

    private AudioSource audioSource;

    // Use this for initialization
    void Start () {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = whatHappened;
        audioSource.Play();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnFindLandingZone ()
    {
        Debug.Log(name + " OnFindLandingZone");
        audioSource.clip = goodLandingZone;
        audioSource.Play();

        // What for the clip to play and call method
        Invoke("CallHeli", goodLandingZone.length + 1f);
    }

    private void CallHeli ()
    {
        SendMessageUpwards("OnMakeInitialHeliCall");
    }
}
