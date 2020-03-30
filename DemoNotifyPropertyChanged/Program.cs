using System;

namespace DemoNotifyPropertyChanged
{
    class Program
    {
        static void Main(string[] args)
        {
            View view = new View();
            ViewModel viewModel = new ViewModel();
            ViewModel viewModel2 = new ViewModel();

            view.DataContext = viewModel;

            viewModel.Value = 10;
            viewModel.Value = 10;
            viewModel.Value = 20;

            view.DataContext = viewModel2;
            viewModel2.Value = 5;
        }
    }
}
