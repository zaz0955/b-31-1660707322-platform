using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : Weapon

{
    Rigidbody2D rb2d;
    Vector2 force;
    void Start()
    {
        Damage = 40;
        Move();
    }
    void Update()

    {
    
    }

    public override void Move()
    {
        Debug.Log($"{this.name} move with Rigidbody:force ");
    }
    public override void OnHitWith(Character character)
    {
        Console.WriteLine($"{this.name}: Overriding OnHitWith(Character) ");
    }
}
