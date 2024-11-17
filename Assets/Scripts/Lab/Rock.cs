using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : Weapon
{

    Rigidbody2D rb2d;
    Vector2 force;


    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        Damage = 20;
        force = new Vector2(GetShootDirection() * 5, 10);
        Move();
    }
    void Update()
    {

    }
    public override void Move()
    {
        rb2d.AddForce(force);
        //Debug.Log("Rock move with RigiBody: force");

    }
    public override void OnHitWith(Character character)
    {
        if (character is Player)
            character.TakeDamage(Damage);
    }

}