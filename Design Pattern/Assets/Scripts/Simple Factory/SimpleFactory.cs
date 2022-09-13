using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleFactory : MonoBehaviour
{
    public static SimpleFactory Instance;

    private void Awake()
    {
        Instance = this;
    }

    public Goblin CreateMonster(string txt)
    {
        Goblin goblin = null;

        if (txt.Equals("Green"))
        {
            goblin = gameObject.AddComponent<GreenGoblin>();
        }
        else if (txt.Equals("Red"))
        {
            goblin = gameObject.AddComponent<RedGoblin>();
        }

        return goblin;
    }


}
