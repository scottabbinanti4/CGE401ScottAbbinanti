/*
 * Scott Abbinanti
 * SpawnManagerP3
 * CGE 401 Prototype 3
 * Script to spawn obstacles
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerP3 : MonoBehaviour
{
    public GameObject obstaclePrefab;

    private Vector3 spawnPosition = new Vector3 (25, 0, 0);

    private float startDelay = 2;
    private float repeatRate = 2;

    private PlayerControllerP3 playerControllerP3Script;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerP3Script = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControllerP3>();

        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    void SpawnObstacle()
    {
        if (playerControllerP3Script.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPosition, obstaclePrefab.transform.rotation);
        }
    }
}
