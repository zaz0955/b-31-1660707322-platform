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
            GameObject obj = Instantiate(Bullet, BulletSpawnPoint.position, Quaternion.identity);
            Banana banana = obj.GetComponent<Banana>();
<<<<<<< HEAD
=======
            banana.Init(10, this);
>>>>>>> fd487ee8ebcb650c0aa855a62a0961c569afda37
            BulletTimer = 0;
        }
    }

    private void Start()
    {
        Init(100);
        BulletTimer = 0.0f;
        BulletSpawnTime = 2.0f;
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
