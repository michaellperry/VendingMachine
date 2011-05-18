using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Silverlight.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendingMachine.Logic.ViewModels;
using VendingMachine.Logic.Models;
using VendingMachine.Logic.SessionModels;

namespace VendingMachine.UnitTest
{
    [TestClass]
    public class UnitTest : SilverlightTest
    {
        private VendingMachineViewModel _viewModel;

        [TestInitialize]
        public void Initialize()
        {
            _viewModel = new VendingMachineViewModel(new Catalog().AddProduct("Doritos").AddProduct("Cheezits"), new VendingMachineNavigationModel());
        }

        [TestMethod]
        public void CanListAllProducts()
        {
            IEnumerable<ProductViewModel> products = _viewModel.Products;
            Assert.AreEqual(2, products.Count());
            Assert.AreEqual("Doritos", products.ElementAt(0).Description);
            Assert.AreEqual("Cheezits", products.ElementAt(1).Description);
        }

        [TestMethod]
        public void CanSelectAProduct()
        {
            _viewModel.SelectedProduct = _viewModel.Products.First();

            Assert.AreEqual("Doritos", _viewModel.SelectedProduct.Description);
        }

        [TestMethod]
        public void InitiallyNoQuantity()
        {
            Assert.IsNull(_viewModel.Quantity);
        }

        [TestMethod]
        public void WhenAProductIsSelected_ThenQuantityAppears()
        {
            _viewModel.SelectedProduct = _viewModel.Products.First();

            Assert.IsNotNull(_viewModel.Quantity);
        }
    }
}
