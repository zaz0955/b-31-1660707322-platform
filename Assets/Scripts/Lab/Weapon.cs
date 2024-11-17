using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    public int Damage {  get; set; }
    protected string Owner; // เจ้าของอาวุธ

    protected IShootable shooter;

    // Method ที่เป็น abstract ไว้ให้คลาสลูก implement

    public abstract void OnHitWith(Character character);
    public abstract void Move();

    public void Init(int _damage, IShootable _owner)
    {
        Damage = _damage;
        shooter = _owner;
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        OnHitWith(other.GetComponent<Character>());
        Destroy(this.gameObject, 6f);
    }
    // Method กำหนดทิศทางการยิง
    public int GetShootDirection()
    {
        float shootdir = shooter.BulletSpawnPoint.position.x - shooter.BulletSpawnPoint.parent.position.x;
        if (shootdir > 0) 
            return 1;
        else return -1;
    }

    
}
