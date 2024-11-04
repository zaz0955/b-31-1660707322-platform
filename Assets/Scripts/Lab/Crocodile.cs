using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class Crocodile : Enemy , IShootable
{
    [SerializeField] private float attackRange;
    public Player player;

    [field: SerializeField] public GameObject Bullet { get; set; }
    [field: SerializeField] public Transform BulletSpawnPoint { get; set; }
    [field: SerializeField] public float BulletSpawnTime { get; set; }
    [field: SerializeField] public float BulletTimer { get; set; }
    private void Update()
    {
        BulletTimer -= Time.deltaTime;

        Behaviour();

        if (BulletTimer < 0f)
        {
            BulletTimer = BulletSpawnTime;
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

    public void Shoot()
    {
        if (BulletTimer <= 0)
        {
            Instantiate(Bullet, BulletSpawnPoint.position, Quaternion.identity);
        }

    }
}
