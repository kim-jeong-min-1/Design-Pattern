/// <summary>
/// 옵저버 관리, 활용에 관한 인터페이스 메서드가 있음.
/// </summary>
public interface ISubject
{
    void AddObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void Notify();
}