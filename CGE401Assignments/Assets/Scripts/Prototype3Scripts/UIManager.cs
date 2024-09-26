/*
 * Scott Abbinanti
 * UIManager
 * CGE 401 Prototype 3
 * Script to control UI Events
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;

    public PlayerControllerP3 playerControllerP3Script;

    public bool won = false;

    // Start is called before the first frame update
    void Start()
    {
        if(scoreText == null)
        {
            scoreText = FindObjectOfType<Text>();
        }

        if(playerControllerP3Script == null)
        {
            playerControllerP3Script = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControllerP3>();
        }

        scoreText.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        if (!playerControllerP3Script.gameOver)
        {
            scoreText.text = "Score: " + score;
        }

        if(playerControllerP3Script.gameOver && !won)
        {
            scoreText.text = "You Lose!" + "\n" + "Press R to Try Again!";
        }

        if(score >= 10)
        {
            playerControllerP3Script.gameOver = true;
            won = true;

            //playerControllerP3Script.StopRunning();

            scoreText.text = "You Win!" + "\n" + "Press R to Try Again";
        }

        if(playerControllerP3Script.gameOver && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
