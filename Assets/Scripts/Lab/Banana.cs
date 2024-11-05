using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : Weapon
{
    
    [SerializeField] public float speed;

     void Start()
    {
        Damage = 10;
        speed = 4.0f * GetShootDirection();
    }

    // Override Method สำหรับการเคลื่อนที่
    public override void Move()
    {
        float newX = transform.position.x + speed * Time.deltaTime;
        float newY = transform.position.y;
        Vector2 newPosition = new Vector2(newX, newY);
        transform.position = newPosition;
        //Debug.Log("Banana moves with transform at constant speed.");
    }
     void FixedUpdate()
    {
        Move();  
    }

    // เมื่อปะทะกับ Character
    public override void OnHitWith(Character character)
    {
        if (character is Enemy)
            character.TakeDamage(this.Damage);
        //Debug.Log($"{this.name}: Overriding OnhitWith(Character) ");
    }
}
