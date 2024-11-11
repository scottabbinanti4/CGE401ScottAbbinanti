/*
 * Scott Abbinanti
 * Enemy
 * Assignment 6 Easy Mode
 * Enemy Class
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    protected float speed;
    protected int health;


    protected virtual void Awake()
    {
        speed = 5f;
        health = 100;
    }

    protected abstract void TakeDamage(int amount);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
