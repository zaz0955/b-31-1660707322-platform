using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character , IShootable
{
    [SerializeField] public GameObject Bullet { get; set; }
    [SerializeField] public Transform SpawnPoint { get; set; }

    public float ReloadTime { get; set; }

    public float WaitTime { get; set; }

    public void Shoot()
    {
        if (Input.GetButtonDown("Fire") && (WaitTime >= ReloadTime))
        {
            Instantiate(Bullet, SpawnPoint.position, Quaternion.identity);
            WaitTime = 0;
        }
    }

    void Start()
    {
        Init(100);
    }
    void Update()
    {
        Shoot();
    }
}
