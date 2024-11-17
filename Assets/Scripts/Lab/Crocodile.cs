using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class Crocodile : Enemy, IShootable
{
    [SerializeField] private float attackRange;
    public Player player;

    [field: SerializeField] public GameObject Bullet { get; set; }
    [field: SerializeField] public Transform BulletSpawnPoint { get; set; }
    [field: SerializeField] public float BulletSpawnTime { get; set; }
    [field: SerializeField] public float BulletTimer { get; set; }

    void Start()
    {
        Init(100);
        BulletTimer = 0.0f;
        BulletSpawnTime = 0.0f;
        DamageHit = 30;
        attackRange = 6.0f;
        player = GameObject.FindObjectOfType<Player>();
    }
    void Update()
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
            GameObject obj = Instantiate(Bullet, BulletSpawnPoint.position, Quaternion.identity);
            Rock rock = obj.GetComponent<Rock>();
            rock.Init(20, this);
            BulletTimer = 0f;
        }

    }
}