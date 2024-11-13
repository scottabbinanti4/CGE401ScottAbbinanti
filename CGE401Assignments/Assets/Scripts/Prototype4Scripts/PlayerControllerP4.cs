/*
 * Scott Abbinanti
 * PlayerControllerP4
 * CGE 401 Prototype 4
 * Script to Control player
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerP4 : MonoBehaviour
{
    private Rigidbody playerRb;
    public float speed;
    private float forwardInput;

    private GameObject focalPoint;


    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.FindGameObjectWithTag("FocalPoint");
    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        
    }

    void FixedUpdate()
    {
        playerRb.AddForce(focalPoint.transform.forward * speed * forwardInput);
    }
}
