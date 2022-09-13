using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_01 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Goblin Greengoblin = SimpleFactory.Instance.CreateMonster("Green");
        Goblin Redgoblin = SimpleFactory.Instance.CreateMonster("Red");
    }
}
