using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using VendingMachine.Logic.SessionModels;
using VendingMachine.Logic.Models;
using UpdateControls.XAML;

namespace VendingMachine.Logic.ViewModels
{
    public class QuantityViewModel
    {
        private VendingMachineNavigationModel _navigation;
        private Order _order;

        public QuantityViewModel(VendingMachineNavigationModel navigation, Order order)
        {
            _navigation = navigation;
            _order = order;
        }

        public int Quantity
        {
            get { return _navigation.Quantity; }
            set { _navigation.Quantity = value; }
        }

        public ICommand Add
        {
            get
            {
                return MakeCommand
                    .Do(() =>
                    {
                        _order.AddOrderLine(_navigation.Quantity, _navigation.SelectedProduct);
                        _navigation.SelectedProduct = null;
                    });
            }
        }
    }
}
