﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunContainer : MonoBehaviour
{
    public static readonly Gun pistol = new Gun(0,0.5f, 1, 0f, 9, "Pistol", 20, 10);
    public static readonly Gun shotgun = new Gun(1,1f, 5, 3.5f, 9, "Shotgun", 20, 15);
    public static readonly Gun rifle = new Gun(2,0.1f, 1, 1f, 9, "Rifle", 30, 60);
    public static readonly Gun minigun = new Gun(3,0.05f, 1, 2.5f, 9, "Minigun", 20, 120);

    public static List<Gun> guns;

    private void Awake()
    {
        guns = new List<Gun>();
        guns.Add(pistol);
        guns.Add(shotgun);
        guns.Add(rifle);
        guns.Add(minigun);
    }

    public static Gun GetGun(int n)
    {
        return guns[n];
    }
}
