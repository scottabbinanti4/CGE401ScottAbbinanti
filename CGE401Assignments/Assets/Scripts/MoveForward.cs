﻿/*
 * Scott Abbinanti
 * MoveForward
 * CGE 401 Prototype 2
 * Moves animals and food forward
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 40;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
