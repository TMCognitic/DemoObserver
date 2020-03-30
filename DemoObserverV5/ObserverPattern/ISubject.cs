using System;

namespace DemoObserver.ObserverPattern
{
    public interface ISubject
    {
        event Action<ISubject> NotifyHandler;
    }
}