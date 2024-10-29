using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : Weapon
{
    [SerializeField] float speed;
    void Start()
    {
        Damage = 30;
        speed = 4.0f;
        Move();
    }
    void Update()
    { 
    
    }
    public override void Move()
    {
        Debug.Log($"{this.name} moves with constant speed using Transform");
    }
    public override void OnHitWith(Character character)
    {
        Console.WriteLine($"{this.name}: Overriding OnHitWith(Character) ");
    }
}