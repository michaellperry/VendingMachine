﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VendingMachine.Logic.Models;
using VendingMachine.Logic.SessionModels;

namespace VendingMachine.Logic.ViewModels
{
    public class VendingMachineViewModel
    {
        private Catalog _catalog;
        private VendingMachineNavigationModel _navigation;

        public VendingMachineViewModel(Catalog catalog, VendingMachineNavigationModel navigation)
        {
            _catalog = catalog;
            _navigation = navigation;
        }

        public IEnumerable<ProductViewModel> Products
        {
            get
            {
                return
                    from product in _catalog.Products
                    select new ProductViewModel(product);
            }
        }

        public ProductViewModel SelectedProduct
        {
            get { return new ProductViewModel(_navigation.SelectedProduct); }
            set { _navigation.SelectedProduct = value.Product; }
        }

        public QuantityViewModel Quantity
        {
            get { return _navigation.SelectedProduct == null ? null : new QuantityViewModel(); }
        }
    }
}