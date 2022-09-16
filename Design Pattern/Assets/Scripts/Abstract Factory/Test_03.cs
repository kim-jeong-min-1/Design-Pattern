using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_03 : MonoBehaviour
{
    public void SpawnBoss()
    {
        AbstractFactory bossFactory = new BossFactory();
        Boss boss = bossFactory.CreateBoss();
    }
}
