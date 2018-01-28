using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public Transform playerSpawnPoints;
    public bool respawn;

    private Transform [] spawnPoints;

	// Use this for initialization
	void Start () {
        //GameObject spawnPoints = GameObject.FindGameObjectWithTag("Player Spawn Points");
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
}
