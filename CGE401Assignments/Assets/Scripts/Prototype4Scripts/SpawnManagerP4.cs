/*
 * Scott Abbinanti
 * SpawnManager
 * CGE 401 Prototype 4
 * Spawns enemy prefabs
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerP4 : MonoBehaviour
{
    public GameObject enemyPrefab;

    private float spawnRange = 9;

    // Start is called before the first frame update
    void Start()
    {

        Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
    }

    private Vector3 GenerateSpawnPosition()
    {
        float spawnPositionX = Random.Range(-spawnRange, spawnRange);
        float spawnPositionZ = Random.Range(-spawnRange, spawnRange);

        Vector3 randomPos = new Vector3(spawnPositionX, 0, spawnPositionZ);
        return randomPos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
