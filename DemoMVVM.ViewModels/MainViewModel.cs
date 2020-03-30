using Patterns.Mediator;
using Patterns.MVVM.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace DemoMVVM.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private int _value;

        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<int> _items;

        private RelayCommand _incrementCommand, _decrementCommand, _addCommand;

        public int Value
        {
            get
            {
                return _value;
            }

            set
            {
                if (_value != value)
                {
                    _value = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Value)));                    
                }
            }
        }

        public ObservableCollection<int> Items
        {
            get
            {
                return _items ??= new ObservableCollection<int>(); ;
            }
        }

        public RelayCommand IncrementCommand
        {
            get
            {
                return _incrementCommand ??= new RelayCommand(Increment, CanIncrement);
            }
        }

        public RelayCommand DecrementCommand
        {
            get
            {
                return _decrementCommand ??= new RelayCommand(Decrement, CanDecrement);
            }
        }

        public RelayCommand AddCommand
        {
            get
            {
                return _addCommand ??= new RelayCommand(Add, CanAdd);                
            }
        }

        public MainViewModel()
        {
            //Task task = new Task(() =>
            //{
            //    Task.Delay(3000).Wait();
            //    while (Value < 10)
            //    {
            //        Value++;

            //        Application.Current.Dispatcher.Invoke(() => Items.Add(Value));
            //        Task.Delay(1000).Wait();
            //    }
            //});

            //task.Start();
        }

        private void Increment()
        {
            Value++;
        }

        private bool CanIncrement()
        {
            return Value < 9;
        }

        private void Decrement()
        {
            Value--;
        }

        private bool CanDecrement()
        {
            return Value > 0;
        }

        private void Add()
        {
            Items.Add(Value);
            //Ouvrir la ResultWindow
            Messenger<string>.Instance.Send("OpenResultWindow");
        }

        private bool CanAdd()
        {
            return !Items.Contains(Value);
        }
    }
}
