using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public Transform playerSpawnPoints;
    public GameObject landingZone;

    private Transform [] spawnPoints;
    private bool respawn;

    // Use this for initialization
    void Start () {
        spawnPoints = playerSpawnPoints.GetComponentsInChildren<Transform>();
        Debug.Log(spawnPoints.Length);
	}
	
	// Update is called once per frame
	void Update () {
		if (respawn)
        {
            respawn = false;
            ReSpawn();
        }
	}

    public void ReSpawn()
    {
        int spawnPoint = Random.Range(1, spawnPoints.Length);
        transform.position = spawnPoints[spawnPoint].position;
    }

    private void OnFindLandingZone ()
    {
        Debug.Log("Found Clear Landing Zone");
        Invoke("DropFlare", 3f);

        // helicopter.Call();
        // Deploy flare
        // Spawn Zombies
    }

    private void DropFlare ()
    {
        Debug.Log("Dropped flare");
        Instantiate(landingZone, transform.position, transform.rotation);
    }
}
