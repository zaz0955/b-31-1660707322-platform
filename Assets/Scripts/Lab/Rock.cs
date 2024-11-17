using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : Weapon
{
<<<<<<< HEAD

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

=======
    Rigidbody2D rb2d;
    Vector2 force;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        Damage = 20;
        force = new Vector2 (GetShootDirection() * 100, 400);
        Move();
    }


    public override void Move()
    {
        rb2d.AddForce(force, ForceMode2D.Impulse);
>>>>>>> fd487ee8ebcb650c0aa855a62a0961c569afda37
    }
    public override void OnHitWith(Character character)
    {
        if (character is Player)
<<<<<<< HEAD
            character.TakeDamage(Damage);
=======
        {
            character.TakeDamage(this.Damage);
        }
>>>>>>> fd487ee8ebcb650c0aa855a62a0961c569afda37
    }

}