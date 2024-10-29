using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class Crocodile : Enemy , IShootable
{
     float attackRange;

    public float AttackRange { get { return attackRange; } set { attackRange = value; } }
    public Player player;

    [SerializeField] public GameObject Bullet { get; set; }
    [SerializeField] public Transform SpawnPoint { get; set; }

    [SerializeField] public float ReloadTime { get; set; }

    [SerializeField] public float WaitTime { get; set; }


    private void Start()
    {
        Init(30);
    }
    private void Update()
    {
        WaitTime -= Time.deltaTime;

        Behaviour();

        if (WaitTime < 0f)
        {
            WaitTime = ReloadTime;
        }
    }
    public override void Behaviour()
    {
        Vector2 direction = player.transform.position - transform.position;
        float distance = direction.magnitude;
        
        if (distance < attackRange)
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        if (WaitTime >= ReloadTime)
        {
            anim.SetTrigger("Shoot");
            GameObject obj = Instantiate(Bullet, SpawnPoint.position, Quaternion.identity);
            WaitTime = 0f;
        }
        
    }
}
