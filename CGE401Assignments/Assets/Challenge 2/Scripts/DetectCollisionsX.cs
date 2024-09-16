/*
 * Scott Abbinanti
 * DetectCollisionsX
 * CGE 401 Challenge 2
 * Detects collision between dog and ball
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
    private DisplayScoreX2 displayScoreScript;

    private void Start()
    {
        displayScoreScript = GameObject.FindGameObjectWithTag("DisplayScoreText").GetComponent<DisplayScoreX2>();
    }


    private void OnTriggerEnter(Collider other)
    {
        displayScoreScript.score++;
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
