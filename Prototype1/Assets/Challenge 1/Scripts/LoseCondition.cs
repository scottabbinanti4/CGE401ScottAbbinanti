/*
 * Scott Abbinanti
 * LoseCondition
 * CGE 401 Challenge 1
 * Creates a loss if player goes too high or low
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoseCondition : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 80 || transform.position.y < -51)
        {
            ScoreManager.gameOver = true;
        }
    }
}
