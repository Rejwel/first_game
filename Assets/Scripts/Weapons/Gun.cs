﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun
{
    private int id;
    private float fireRate;
    private int bullets;
    private float spread;
    private float speed;
    private string description;
    private int damage;
    private int magazine;

    public Gun(int id, float fireRate, int bullets, float spread, float speed, string desc, int damage, int magazine)
    {
        this.id = id;
        this.fireRate = fireRate;
        this.bullets = bullets;
        this.spread = spread;
        this.speed = speed;
        this.description = desc;
        this.damage = damage;
        this.magazine = magazine;
    }

    public float GetFireRate()
    {
        return fireRate;
    }
    
    public int GetBullets()
    {
        return bullets;
    }
    
    public float GetSpread()
    {
        return spread;
    }
    
    public float GetSpeed()
    {
        return speed;
    }
    
    public string GetDesc()
    {
        return description;
    }
    
    public int GetDamage()
    {
        return damage;
    }
    
    public int GetMagazine()
    {
        return magazine;
    }
    
    public int GetId()
    {
        return id;
    }
}
