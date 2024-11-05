using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] int damage;
    public int Damage {  get { return damage; } set { damage = value; } }
    
    protected IShootable shooter;

    //abstract methods
    public abstract void OnHitWith(Character character);
    public abstract void Move();

    public void Init(int _damage, IShootable _owner)
    {
        Damage = _damage;
        shooter = _owner;
    }
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
    }


}
