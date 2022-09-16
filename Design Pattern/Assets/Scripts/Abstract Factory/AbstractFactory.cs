using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractFactory
{
    public Boss CreateBoss()
    {
        Boss boss = new Boss
        {
            monster = CreateMonster((MonsterType)Random.Range(0, 2)),
            weapon = CreateWeapon((WeaponType)Random.Range(0, 2))
        };

        return boss;
    }

    public abstract Mon CreateMonster(MonsterType monsterType);
    public abstract Weapon CreateWeapon(WeaponType weaponType);

}
