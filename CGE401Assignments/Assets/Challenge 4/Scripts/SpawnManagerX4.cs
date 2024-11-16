using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SpawnManagerX4 : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject powerupPrefab;

    private float spawnRangeX = 10;
    private float spawnZMin = 15; // set min spawn Z
    private float spawnZMax = 25; // set max spawn Z

    public int enemyCount;
    public int waveCount = 1;


    public GameObject player;

    public float enemySpeed;

    public Text textbox;
    public bool gameOver = false;
    public GameObject winText;
    public GameObject loseText;

    public int collidedWithPlayerGoal = 0;
    public bool inRound = false;

    public bool gameStarted = false;
    public GameObject panel;

    void Start()
    {
        enemySpeed = 100;
        gameOver = true;
    }

    void StartGame()
    {
        

        gameStarted = true;
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        textbox.text = "Wave: " + (waveCount - 1);

        //enemySpeed = enemyPrefab.GetComponent<EnemyX4>().speed;
        enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;

        if(gameStarted == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                panel.SetActive(false);
                StartGame();
            }
        }

        if(gameOver == false)
        {
            if (enemyCount == 0 && inRound == false)
            {
                inRound = true;
                StartCoroutine(SpawnEnemyWave(waveCount));
                enemySpeed += 25;
                //collidedWithPlayerGoal = 0;
            }
        }

        if (gameStarted)
        {
            if ((waveCount - 1) > 10)
            {
                gameOver = true;
                winText.SetActive(true);

            }
            if (collidedWithPlayerGoal == (waveCount - 1))
            {
                gameOver = true;
                loseText.SetActive(true);

            }
        }

        if (gameOver)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }

    }

    // Generate random spawn position for powerups and enemy balls
    Vector3 GenerateSpawnPosition ()
    {
        float xPos = Random.Range(-spawnRangeX, spawnRangeX);
        float zPos = Random.Range(spawnZMin, spawnZMax);
        return new Vector3(xPos, 0, zPos);
    }


    IEnumerator SpawnEnemyWave(int enemiesToSpawn)
    {
        if((waveCount - 1) >= 1) { yield return new WaitForSeconds(0.5f); }
            
        Vector3 powerupSpawnOffset = new Vector3(0, 0, -15); // make powerups spawn at player end

        // If no powerups remain, spawn a powerup
        if (GameObject.FindGameObjectsWithTag("Powerup").Length == 0) // check that there are zero powerups
        {
            Instantiate(powerupPrefab, GenerateSpawnPosition() + powerupSpawnOffset, powerupPrefab.transform.rotation);
        }

        // Spawn number of enemy balls based on wave number
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
        }

        waveCount++;
        ResetPlayerPosition(); // put player back at start
        collidedWithPlayerGoal = 0;
        inRound = false;

    }

    // Move player back to position in front of own goal
    void ResetPlayerPosition ()
    {
        player.transform.position = new Vector3(0, 1, -7);
        player.GetComponent<Rigidbody>().velocity = Vector3.zero;
        player.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;

    }

}
