﻿/*
 * Scott Abbinanti
 * DestroyOutOfBounds
 * CGE 401 Prototype 2
 * Destroys food and animal objects that go out of range of play
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound = 20;
    public float bottomBound = -10;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBound)
        {
            Destroy(gameObject);
        }

        if(transform.position.z < bottomBound)
        {
            GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>().TakeDamage();

            Destroy(gameObject);
        }
    }
}
