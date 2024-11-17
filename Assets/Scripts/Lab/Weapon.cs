using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
<<<<<<< HEAD
    public int Damage {  get; set; }
    protected string Owner; // เจ้าของอาวุธ

    protected IShootable shooter;

    // Method ที่เป็น abstract ไว้ให้คลาสลูก implement
=======
    [SerializeField] int damage;
    public int Damage {  get { return damage; } set { damage = value; } }
    
    protected IShootable shooter;
>>>>>>> fd487ee8ebcb650c0aa855a62a0961c569afda37

    //abstract methods
    public abstract void OnHitWith(Character character);
    public abstract void Move();

    public void Init(int _damage, IShootable _owner)
    {
        Damage = _damage;
        shooter = _owner;
    }
<<<<<<< HEAD


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
=======
    public int GetShootDirection()
    {
        float shootDir = shooter.BulletSpawnPoint.position.x - shooter.BulletSpawnPoint.parent.position.x;

        if (shootDir > 0)

            return 1; //right direction

        else return -1; // left direction
    }
  
    void OnTriggerEnter2D(Collider2D other)
    {
        OnHitWith(other.GetComponent<Character>());
>>>>>>> fd487ee8ebcb650c0aa855a62a0961c569afda37
    }


}
