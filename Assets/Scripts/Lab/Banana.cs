using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : Weapon
{
<<<<<<< HEAD
    [SerializeField] float speed;
=======
    
    [SerializeField] public float speed;

     void Start()
    {
        Damage = 10;
        speed = 4.0f * GetShootDirection();
    }
>>>>>>> fd487ee8ebcb650c0aa855a62a0961c569afda37

    private void Start()
    {
        Damage = 10;
        speed = 4.0f * GetShootDirection();
    }
    // Override Method สำหรับการเคลื่อนที่
    public override void Move()
    {
<<<<<<< HEAD
        //Debug.Log("Banana moves with transform at constant speed.");
        float newX = transform.position.x + speed * Time.fixedDeltaTime;
        float newY = transform.position.y;
        Vector2 newPositon = new Vector2(newX, newY);
        transform.position = newPositon;
    }
    private void FixedUpdate()
    {
        Move();
=======
        float newX = transform.position.x + speed * Time.deltaTime;
        float newY = transform.position.y;
        Vector2 newPosition = new Vector2(newX, newY);
        transform.position = newPosition;
        //Debug.Log("Banana moves with transform at constant speed.");
    }
     void FixedUpdate()
    {
        Move();  
>>>>>>> fd487ee8ebcb650c0aa855a62a0961c569afda37
    }
    // เมื่อปะทะกับ Character
    public override void OnHitWith(Character character)
    {
<<<<<<< HEAD
       if (character is Enemy)
            character.TakeDamage(this.Damage);
=======
        if (character is Enemy)
            character.TakeDamage(this.Damage);
        //Debug.Log($"{this.name}: Overriding OnhitWith(Character) ");
>>>>>>> fd487ee8ebcb650c0aa855a62a0961c569afda37
    }
}
