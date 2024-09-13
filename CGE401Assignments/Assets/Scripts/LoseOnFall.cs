/*
 * Scott Abbinanti
 * LoseOnFall
 * CGE 401 Prototype 1
 * Script that creates lose condition if player falls of track
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoseOnFall : MonoBehaviour
{
    //public Text Textbox;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -1)
        {
            //Textbox.text = "You Lose!";
            ScoreManager.gameOver = true;
        }
    }
}
