using System;
using System.Collections;
using System.Collections.Specialized;
using System.Text;

namespace DemoNotifyCollectionChanged
{
    public class ItemsControl
    {
        private IEnumerable _itemsSource;

        public IEnumerable ItemsSource
        {
            get
            {
                return _itemsSource;
            }

            set
            {
                if(!(_itemsSource is null) && _itemsSource is INotifyCollectionChanged)
                {
                    INotifyCollectionChanged notifyCollectionChanged = (INotifyCollectionChanged)_itemsSource;
                    notifyCollectionChanged.CollectionChanged -= OnCollectionChanged;
                }
                _itemsSource = value;
                if (!(_itemsSource is null) && _itemsSource is INotifyCollectionChanged)
                {
                    INotifyCollectionChanged notifyCollectionChanged = (INotifyCollectionChanged)_itemsSource;
                    notifyCollectionChanged.CollectionChanged += OnCollectionChanged;
                }
            }
        }

        private void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch(e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    Console.WriteLine($"Un nouvel élément a été ajouté à l'index '{e.NewStartingIndex}' : {e.NewItems[0]}");
                    break;
                case NotifyCollectionChangedAction.Remove:
                    Console.WriteLine($"Un élément a été supprimé à l'index '{e.OldStartingIndex}' : {e.OldItems[0]}");
                    break;
                case NotifyCollectionChangedAction.Replace:
                    Console.WriteLine($"L'élément à l'index '{e.NewStartingIndex}' dont la valeur était : {e.OldItems[0]} a été remplacé par : {e.NewItems[0]}");
                    break;
                case NotifyCollectionChangedAction.Reset:
                    Console.WriteLine("La collection a été vidée de son contenu");
                    break;
            }
        }
    }
}
