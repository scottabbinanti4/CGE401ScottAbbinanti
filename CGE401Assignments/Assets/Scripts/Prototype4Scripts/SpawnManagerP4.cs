/*
 * Scott Abbinanti
 * SpawnManager
 * CGE 401 Prototype 4
 * Spawns enemy prefabs
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnManagerP4 : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject powerupPrefab;

    private float spawnRange = 9;

    public int enemyCount;
    public int waveNumber = 1;

    public Text Textbox;
    public bool gameOver = false;

    public GameObject dialogPanel;
    private bool gameStarted = false;

    // Start is called before the first frame update
    void Start()
    {
        Textbox.text = "Wave: " + waveNumber;

        gameOver = true;
    }

    void StartGame()
    {
        SpawnEnemyWave(waveNumber);
        SpawnPowerup(1);

        gameStarted = true;
        gameOver = false;
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
        if(gameStarted == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                dialogPanel.SetActive(false);
                StartGame();
            }
        }

        Textbox.text = "Wave: " + waveNumber;
        enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;

        if (gameOver == false)
        {
            if (enemyCount == 0)
            {
                waveNumber++;
                SpawnEnemyWave(waveNumber);
                SpawnPowerup(1);
            }
        }
    }

    void SpawnEnemyWave(int enemiesToSpawn)
    {
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
        }
    }

    void SpawnPowerup(int powerupsToSpawn)
    {
        for (int i = 0; i < powerupsToSpawn; i++)
        {
            Instantiate(powerupPrefab, GenerateSpawnPosition(), powerupPrefab.transform.rotation);
        }
    }
}
