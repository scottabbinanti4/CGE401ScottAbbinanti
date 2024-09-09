/*
 * Scott Abbinanti
 * PlayerEnterTrigger
 * CGE 401 Prototype 1
 * Script for when player Enters trigger zone
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerEnterTrigger : MonoBehaviour
{
    //public Text Textbox;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TriggerZone"))
        {
            //Textbox.text = "You Win!";
            ScoreManager.score++;
        }
    }
}
