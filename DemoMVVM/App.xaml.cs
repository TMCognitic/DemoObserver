using Patterns.Mediator;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace DemoMVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Messenger<string>.Instance.Register(OnNewMessage);
        }

        private void OnNewMessage(string message)
        {
            switch(message)
            {
                case "OpenResultWindow":
                    ResultWindow resultWindow = new ResultWindow();
                    resultWindow.ShowDialog();
                    break;
            }
        }
    }
}
