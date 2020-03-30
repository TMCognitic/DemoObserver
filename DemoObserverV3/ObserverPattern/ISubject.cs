using System;

namespace DemoObserver.ObserverPattern
{
    public interface ISubject
    {
        void Attach(Action<ISubject> action);
        void Detach(Action<ISubject> action);
    }
}