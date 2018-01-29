using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioSystem : MonoBehaviour {

    public AudioClip heliCall;
    public AudioClip heliCallReply;

    private AudioSource audioSource;

    // Use this for initialization
    void Start () {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnMakeInitialHeliCall ()
    {
        Debug.Log(name + " OnMakeInitialHeliCall");
        audioSource.clip = heliCall;
        audioSource.Play();

        Invoke("HeliCallReply", heliCall.length + 1f);
    }

    private void HeliCallReply ()
    {
        audioSource.clip = heliCallReply;
        audioSource.Play();
        BroadcastMessage("OnDispatchHelicopter");
    }
}
