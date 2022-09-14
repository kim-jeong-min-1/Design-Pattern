using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster
{
    public float Hp;
    public float Speed;
    public float Atk_Damage;

    public Monster(float Hp, float Speed, float Atk_Damage)
    {
        this.Hp = Hp;
        this.Speed = Speed;
        this.Atk_Damage = Atk_Damage;
    }
}
