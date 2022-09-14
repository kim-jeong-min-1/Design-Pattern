using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonFactory : MonsterFactory
{
    public override Monster CreateMonster(string type)
    {
        Monster monster = null;

        if (type.Equals("WhiteDragon"))
        {
            monster = new WhiteDragon();
        }
        else if (type.Equals("BlackDragon"))
        {
            monster = new BlackDragon();
        }

        return monster;
    }
}
