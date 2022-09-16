using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WeaponType
{
    Sword,
    Axe
}

public class Weapon
{
    float AtkSpeed;
    float AtkDamage;

    public Weapon(float AtkSpeed, float AtkDamage)
    {
        this.AtkSpeed = AtkSpeed;
        this.AtkDamage = AtkDamage;
    }
}
