using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyObserver2 : IObserver
{
    public void OnNotify()
    {
        Debug.Log("옵저버 메서드 실행 #2");
    }
}
