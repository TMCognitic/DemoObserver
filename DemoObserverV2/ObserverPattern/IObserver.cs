using System;

namespace DemoObserver.ObserverPattern
{
    public interface IObserver
    {
        public void Update(ISubject subject);
    }
}