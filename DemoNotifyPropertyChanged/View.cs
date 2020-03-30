using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;

namespace DemoNotifyPropertyChanged
{
    public class View
    {
        private object _dataContext;

        public object DataContext
        {
            get
            {
                return _dataContext;
            }

            set
            {
                if(!(_dataContext is null) && _dataContext is INotifyPropertyChanged)
                {
                    INotifyPropertyChanged notifyPropertyChanged = (INotifyPropertyChanged)_dataContext;
                    notifyPropertyChanged.PropertyChanged -= OnPropertyChanged;
                }

                _dataContext = value;

                if (!(_dataContext is null) && _dataContext is INotifyPropertyChanged)
                {
                    INotifyPropertyChanged notifyPropertyChanged = (INotifyPropertyChanged)_dataContext;
                    notifyPropertyChanged.PropertyChanged += OnPropertyChanged;
                }
            }
        }

        private void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Type TViewModel = sender.GetType();
            PropertyInfo propertyInfo = TViewModel.GetProperty(e.PropertyName);
            MethodInfo getMethod = propertyInfo.GetMethod;
            object newValue = getMethod.Invoke(sender, null);

            Console.WriteLine($"{sender} notifie que la propriété '{e.PropertyName}' a changée et la nouvelle valeur est : {newValue}");
        }
    }
}
