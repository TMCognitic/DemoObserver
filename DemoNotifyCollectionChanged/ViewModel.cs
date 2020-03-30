using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DemoNotifyCollectionChanged
{
    public class ViewModel
    {
        ObservableCollection<int> _items;

        public ObservableCollection<int> Items
        {
            get
            {
                return _items ??= new ObservableCollection<int>();
            }
        }

        public ViewModel()
        {
            Task task = new Task(() =>
            {
                int value = 0;
                Task.Delay(3000).Wait();
                while (value < 10)
                {
                    Items.Add(value++);
                    Task.Delay(1000).Wait();
                }
            });

            task.Start();
        }
    }
}
