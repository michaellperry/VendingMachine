using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VendingMachine.Logic.Models;
using UpdateControls.Fields;

namespace VendingMachine.Logic.SessionModels
{
    public class VendingMachineNavigationModel
    {
        private Independent<Product> _selectedProduct = new Independent<Product>();
        private Independent<int> _quantity = new Independent<int>();

        public Product SelectedProduct
        {
            get { return _selectedProduct; }
            set { _selectedProduct.Value = value; }
        }

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity.Value = value; }
        }
    }
}
