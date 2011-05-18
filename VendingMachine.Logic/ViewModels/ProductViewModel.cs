using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VendingMachine.Logic.Models;

namespace VendingMachine.Logic.ViewModels
{
    public class ProductViewModel
    {
        private Product _product;

        public ProductViewModel(Product product)
        {
            _product = product;
        }

        public Product Product
        {
            get { return _product; }
        }

        public string Description
        {
            get { return _product.Description; }
        }
    }
}
