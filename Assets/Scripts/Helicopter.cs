using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour {

    private Rigidbody rigidBody;
    private bool heliCalled = false;

    // Use this for initialization
    void Start () {
        rigidBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Call Helicopter"))
        {
            // Call the helicopter
        }
	}

    public void OnDispatchHelicopter ()
    {
        Debug.Log("Helicopter Dispatched");
        heliCalled = true;
        rigidBody.velocity = new Vector3(0f, 0f, 50f);
    }
}
