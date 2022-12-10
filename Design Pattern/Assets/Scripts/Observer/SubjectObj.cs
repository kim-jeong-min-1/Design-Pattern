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
        // IndexOf �޼���� ����Ʈ���� 0�� �ε��� ���� ���� ����� ���ǿ� �´� ���� �ε����� ��ȯ�ϰ�,
        // ���� �������� �ʴ� �ٸ� -1���� ��ȯ����.
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
        //observer���� ����Ʈ�� �߰���.

        MyObserver observer = new MyObserver();
        MyObserver2 observer2 = new MyObserver2();

        observers.Add(observer);
        observers.Add(observer2);


        // ������ �°� �Ǹ� ����Ʈ�� �ִ� ��� ������ �������̽����� �޼��尡 �����.
        if (observers.Count > 0) Notify();
    }
}
