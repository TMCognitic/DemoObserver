using System;
using System.Collections.Generic;
using System.Text;

namespace DemoObserver.ObserverPattern
{
    public abstract class Subject : ISubject
    {
        public event Action<ISubject> NotifyHandler;

        protected void Notify()
        {
            NotifyHandler?.Invoke(this);
        }
    }
}
