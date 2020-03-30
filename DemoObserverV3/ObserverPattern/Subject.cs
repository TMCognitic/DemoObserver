using System;
using System.Collections.Generic;
using System.Text;

namespace DemoObserver.ObserverPattern
{
    public abstract class Subject : ISubject
    {
        private Action<ISubject> _notifyHandler;

        public void Attach(Action<ISubject> action)
        {
            _notifyHandler += action;
        }

        public void Detach(Action<ISubject> action)
        {
            _notifyHandler -= action;
        }

        protected void Notify()
        {
            _notifyHandler?.Invoke(this);
        }
    }
}
