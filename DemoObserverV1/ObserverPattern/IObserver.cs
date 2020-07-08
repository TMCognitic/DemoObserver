using System;

namespace DemoObserver.ObserverPattern
{
    public interface IObserver
    {
        void Update(ISubject subject);
    }
}