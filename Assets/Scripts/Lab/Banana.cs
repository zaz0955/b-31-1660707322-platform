using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : Weapon
{
    public float damage = 30f;
    public float speed = 4f;

    // Override Method สำหรับการเคลื่อนที่
    public override void Move()
    {
        Debug.Log("Banana moves with transform at constant speed.");
        
    }

    // เมื่อปะทะกับ Character
    public override void OnHitWith(Character character)
    {
       
    }
}
