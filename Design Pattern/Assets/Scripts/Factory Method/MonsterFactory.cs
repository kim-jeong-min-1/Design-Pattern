using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MonsterFactory
{
    public abstract Monster CreateMonster(string type);
}
