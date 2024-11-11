using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : Enemy
{

    protected int damage;

    protected override void Awake()
    {
        base.Awake();
        health = 50;
    }

    protected override void Attack(int amount)
    {

    }

    public override void TakeDamage(int amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
