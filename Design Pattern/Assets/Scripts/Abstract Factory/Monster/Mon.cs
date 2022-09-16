using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MonsterType
{
    Troll,
    Skeleton
}

public class Mon
{
    float Hp;
    float Speed;
    float AtkDamage;

    public Mon(float Hp, float Speed, float AtkDamage)
    {
        this.Hp = Hp;
        this.Speed = Speed;
        this.AtkDamage = AtkDamage;
    }
}
