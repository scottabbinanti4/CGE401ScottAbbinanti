/*
 * Scott Abbinanti
 * ScoreManager
 * CGE 401 Prototype 1
 * Script to manage the score of the player
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static bool gameOver;
    public static bool won;
    public static int score;

    public Text Textbox;

    void Start()
    {
        gameOver = false;
        won = false;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameOver)
        {
            Textbox.text = "Score: " + score;
        }

        if(score > 3)
        {
            won = true;
            gameOver = true;
        }

        if (gameOver)
        {
            if (won)
            {
                Textbox.text = "You Win!\nPress R to Try Again";
            }
            else
            {
                Textbox.text = "You Lose!\nPress R to Try Again";
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
