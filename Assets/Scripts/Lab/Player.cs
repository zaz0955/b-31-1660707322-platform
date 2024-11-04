using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character, IShootable
{
    [field: SerializeField] public GameObject Bullet { get; set; }
    [field: SerializeField] public Transform BulletSpawnPoint { get; set; }
    [field: SerializeField] public float BulletSpawnTime { get; set; }
    [field: SerializeField] public float BulletTimer { get; set; }

    public void Shoot()
    {
        if (Input.GetButtonDown("Fire1") && (BulletTimer >= BulletSpawnTime))
        {
            Instantiate(Bullet, BulletSpawnPoint.position, Quaternion.identity);
            BulletTimer = 0;
        }
    }

    private void Start()
    {
        BulletTimer = 0.0f;
        BulletSpawnTime = 1.5f;
    }

    private void Update()
    {
        Shoot();
    }

    private void FixedUpdate()
    {
        BulletTimer += Time.fixedDeltaTime;

        if (BulletTimer >= BulletSpawnTime)
        {
            BulletTimer += BulletSpawnTime;
        }
    }
}
