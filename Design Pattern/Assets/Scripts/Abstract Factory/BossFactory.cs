using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossFactory : AbstractFactory
{
    public override Mon CreateMonster(MonsterType monsterType)
    {
        Mon monster = null;

        if(monsterType == MonsterType.Troll)
        {
            monster = new Troll();
        }
        else if(monsterType == MonsterType.Skeleton)
        {
            monster = new Skeleton();
        }

        return monster;
    }

    public override Weapon CreateWeapon(WeaponType weaponType)
    {
        Weapon weapon = null;

        if (weaponType == WeaponType.Sword)
        {
            weapon = new Sword();
        }
        else if (weaponType == WeaponType.Axe)
        {
            weapon = new Axe();
        }

        return weapon;
    }
}
