using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : Weapon
{
    [SerializeField] float speed;

    private void Start()
    {
        Damage = 10;
        speed = 4.0f * GetShootDirection();
    }
    // Override Method สำหรับการเคลื่อนที่
    public override void Move()
    {
        //Debug.Log("Banana moves with transform at constant speed.");
        float newX = transform.position.x + speed * Time.fixedDeltaTime;
        float newY = transform.position.y;
        Vector2 newPositon = new Vector2(newX, newY);
        transform.position = newPositon;
    }
    private void FixedUpdate()
    {
        Move();
    }
    // เมื่อปะทะกับ Character
    public override void OnHitWith(Character character)
    {
       if (character is Enemy)
            character.TakeDamage(this.Damage);
    }
}
