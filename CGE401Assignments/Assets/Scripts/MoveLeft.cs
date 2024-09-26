/*
 * Scott Abbinanti
 * MoveLeft
 * CGE 401 Prototype 3
 * Destroys Objects out of screen
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 30.0f;
    private float leftBound = -15;

    private PlayerControllerP3 playerControllerP3Script;

    void Start()
    {
        playerControllerP3Script = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControllerP3>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerP3Script.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if(transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
