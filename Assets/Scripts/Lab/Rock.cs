using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : Weapon
{
    public float damage = 40f;
    private Rigidbody2D rb2d;
    private Vector2 force;

    
    public override void Move()
    {
        Debug.Log("Rock move with RigiBody: force");
        
    }
    public override void OnHitWith(Character character)
    {

    }
    
}
