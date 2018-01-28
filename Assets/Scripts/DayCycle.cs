using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayCycle : MonoBehaviour {

    [Tooltip ("Gametime minutes that pass per Realtime seconds: Default = 1")]
    public float timeScale = 1;
    private Quaternion startRotation;

	// Use this for initialization
	void Start () {
        startRotation = transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
        float angleThisFrame = .25f * Time.deltaTime * timeScale;
        transform.RotateAround(transform.position, Vector3.forward, angleThisFrame);
	}
}
