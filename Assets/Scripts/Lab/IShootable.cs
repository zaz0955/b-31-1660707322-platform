using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IShootable
{
    Transform BulletSpawnPoint { get; set; }
    GameObject Bullet { get; set; }

    float BulletSpawnTime { get; set; }
    float BulletTimer { get; set; }

    void Shoot();
}
