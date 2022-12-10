/// <summary>
/// ������ ����, Ȱ�뿡 ���� �������̽� �޼��尡 ����.
/// </summary>
public interface ISubject
{
    void AddObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void Notify();
}