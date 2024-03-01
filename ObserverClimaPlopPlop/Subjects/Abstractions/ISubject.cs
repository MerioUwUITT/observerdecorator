using ObserverClimaPlopPlop.Observers;

namespace ObserverClimaPlopPlop.Subjects
{
    public interface ISubject
    {
        void RegisterObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers();
    }
}
