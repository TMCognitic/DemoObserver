using System;

namespace DemoNotifyCollectionChanged
{
    class Program
    {
        static void Main(string[] args)
        {
            ViewModel viewModel = new ViewModel();

            ObservableCollection<int> items = new ObservableCollection<int>();
            ItemsControl itemsControl = new ItemsControl();

            itemsControl.ItemsSource = items;

            for (int i = 1; i < 4; i++)
            {
                items.Add(i);
            }

            items.Remove(1);
            items[0] = 5;

            items.Clear();

            itemsControl.ItemsSource = viewModel.Items;

            Console.ReadLine();
        }
    }
}
