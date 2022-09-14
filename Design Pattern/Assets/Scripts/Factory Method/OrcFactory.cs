using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrcFactory : MonsterFactory
{
    public override Monster CreateMonster(string type)
    {
        Monster monster = null;

        if (type.Equals("GreenOrc"))
        {
            monster = new GreenOrc();
        }
        else if (type.Equals("BlueOrc"))
        {
            monster = new BlueOrc();
        }

        return monster;
    }
}
