/*
 * Scott Abbinanti
 * Dummy
 * Assignment 6 Easy Mode
 * Dummy Class inheriting from Enemy class
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dummy : Enemy
{
    protected override void Awake()
    {
        base.Awake();

        health = 80;
        speed = 1f;
    }

    protected override void TakeDamage(int amount)
    {
        health -= amount;
    }
}
