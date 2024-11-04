using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    public int Damage {  get; set; }
    protected string Owner; // ��Ңͧ���ظ

    // Method ����� abstract ����������١ implement

    public abstract void OnHitWith(Character character);
    public abstract void Move();

    // Method ��˹���ȷҧ����ԧ
    public int GetShootDirection()
    {
        return 1;
    }

    
}
