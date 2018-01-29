using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandingZone : MonoBehaviour {

    public float collisionTimeLimit = 3f;

    private float deltaClear = 0f;
    private bool landingZoneFound = false;
	
	// Update is called once per frame
	void Update () {
        deltaClear += Time.deltaTime;
        if (deltaClear >= collisionTimeLimit && Time.realtimeSinceStartup > 10f && !landingZoneFound)
        {
            landingZoneFound = true;
            SendMessageUpwards("OnFindLandingZone");
        }
	}

    private void OnTriggerStay(Collider collider)
    {
        if (collider.tag != "Player")
        {
            // landingZoneFound = false;
            deltaClear = 0f;
        }
    }
}
