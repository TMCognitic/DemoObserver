using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Mediator
{
    public class Messenger<TMessage>
    {
        private static Messenger<TMessage> _instance;

        private Action<TMessage> _broadcast;

        public static Messenger<TMessage> Instance
        {
            get
            {
                return _instance ?? (_instance = new Messenger<TMessage>());
            }
        }

        protected Messenger()
        {

        }

        public void Register(Action<TMessage> action)
        {
            _broadcast += action;
        }

        public void Unregister(Action<TMessage> action)
        {
            _broadcast -= action;
        }

        public void Send(TMessage message)
        {
            _broadcast?.Invoke(message);
        }
    }
}
