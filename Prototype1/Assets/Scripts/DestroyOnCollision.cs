/*
 * Scott Abbinanti
 * DestroyOnCollision
 * CGE 401 Prototype 1
 * Destroys obstacles when player collides with them
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
        }
    }
}
