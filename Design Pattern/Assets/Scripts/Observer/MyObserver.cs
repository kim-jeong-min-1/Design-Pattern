using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyObserver : IObserver
{
    public void OnNotify()
    {
        Debug.Log("옵저버 메서드 실행 #1");
    }
}
