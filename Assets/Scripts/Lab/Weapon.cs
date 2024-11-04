using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    public int Damage {  get; set; }
    protected string Owner; // เจ้าของอาวุธ

    // Method ที่เป็น abstract ไว้ให้คลาสลูก implement

    public abstract void OnHitWith(Character character);
    public abstract void Move();

    // Method กำหนดทิศทางการยิง
    public int GetShootDirection()
    {
        return 1;
    }

    
}
