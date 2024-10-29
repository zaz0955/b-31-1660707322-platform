using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IShootable
{
    public GameObject Bullet {  get; set; }
    public Transform SpawnPoint { get; set; }

    public float ReloadTime { get; set; }
    public float WaitTime { get; set; }

}
