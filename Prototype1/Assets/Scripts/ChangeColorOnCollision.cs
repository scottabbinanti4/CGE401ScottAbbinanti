/*
 * Scott Abbinanti
 * ChangeColorOnCollision
 * CGE 401 Prototype 1
 * Changes color of wall when player collides
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOnCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }
}
