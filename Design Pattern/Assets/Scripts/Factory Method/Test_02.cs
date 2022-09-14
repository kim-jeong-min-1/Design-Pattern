using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_02 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MonsterFactory dragonFactory = new DragonFactory();
        Monster whiteDragon = dragonFactory.CreateMonster("WhiteDragon");
        Monster blackDragon = dragonFactory.CreateMonster("BlackDragon");

        MonsterFactory orcFactory = new OrcFactory();
        Monster greenOrc = orcFactory.CreateMonster("GreenOrc");
        Monster blueOrc = orcFactory.CreateMonster("BlueOrc");
    }
}
