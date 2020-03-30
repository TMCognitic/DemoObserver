using System;

namespace DemoObserver.ObserverPattern
{
    public abstract class Observer
    {
        public abstract void Update(Subject subject);
    }
}