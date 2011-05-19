using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using VendingMachine.Logic.ViewModels;
using VendingMachine.Logic.Models;
using VendingMachine.Logic.SessionModels;
using UpdateControls.XAML;

namespace VendingMachine
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void HomeView_Loaded(object sender, RoutedEventArgs e)
        {
            var viewModel = new VendingMachineViewModel(
                new Catalog()
                    .AddProduct("Doritos")
                    .AddProduct("Cheezits"),
                new Order(),
                new VendingMachineNavigationModel());
            DataContext = ForView.Wrap(viewModel);
        }
    }
}
