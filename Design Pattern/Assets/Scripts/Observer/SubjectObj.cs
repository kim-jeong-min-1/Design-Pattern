using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SubjectObj : MonoBehaviour, ISubject
{
    private List<IObserver> observers = new List<IObserver>();

    public void AddObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        // IndexOf 메서드는 리스트에서 0번 인덱스 부터 가장 가까운 조건에 맞는 값의 인덱스를 반환하고,
        // 만약 존재하지 않는 다면 -1값을 반환해줌.
        if (observers.IndexOf(observer) > 0)
        {
            observers.Remove(observer);
        }
    }

    public void Notify()
    {
        foreach(IObserver observer in observers)
        {
            observer.OnNotify();
        }
    }

    private void Start()
    {
        //observer들을 리스트에 추가함.

        MyObserver observer = new MyObserver();
        MyObserver2 observer2 = new MyObserver2();

        observers.Add(observer);
        observers.Add(observer2);


        // 조건이 맞게 되면 리스트에 있는 모든 옵저버 인터페이스에서 메서드가 실행됨.
        if (observers.Count > 0) Notify();
    }
}
