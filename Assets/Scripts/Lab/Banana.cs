using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : Weapon
{
    public float damage = 30f;
    public float speed = 4f;

    // Override Method ����Ѻ�������͹���
    public override void Move()
    {
        Debug.Log("Banana moves with transform at constant speed.");
        
    }

    // ����ͻзСѺ Character
    public override void OnHitWith(Character character)
    {
       
    }
}
