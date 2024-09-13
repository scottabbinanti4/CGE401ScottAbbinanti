﻿/*
 * Scott Abbinanti
 * SpawnManager
 * CGE 401 Prototype 2
 * Allows animals to spawn multiple times, at random, at random x positions
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] prefabsToSpawn;

    private float leftBound = -14;
    private float rightBound = 14;
    private float spawnPosZ = 20;

    public HealthSystem healthSystem;

    void Start()
    {
        //InvokeRepeating("SpawnRandomPrefab", 2, 1.5f);

        healthSystem = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();

        StartCoroutine(SpawnRandomPrefabWithCoroutine());
    }

    IEnumerator SpawnRandomPrefabWithCoroutine()
    {
        yield return new WaitForSeconds(3f);

        while (!healthSystem.gameOver)
        {
            SpawnRandomPrefab();

            float randomDelay = Random.Range(0.8f, 3.5f);

            yield return new WaitForSeconds(randomDelay);
        }
    }

    // Update is called once per frame
    /*
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SpawnRandomPrefab();
        }
    }
    */


    
    void SpawnRandomPrefab()
    {
        int prefabIndex = Random.Range(0, prefabsToSpawn.Length);

        Vector3 spawnPos = new Vector3(Random.Range(leftBound, rightBound), 0, spawnPosZ);

        Instantiate(prefabsToSpawn[prefabIndex], spawnPos, prefabsToSpawn[prefabIndex].transform.rotation);
    }
}
