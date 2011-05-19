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
            _viewModel = new VendingMachineViewModel(
                new Catalog()
                    .AddProduct("Doritos")
                    .AddProduct("Cheezits"),
                new Order(),
                new VendingMachineNavigationModel());
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

        [TestMethod]
        public void CanEnterQuantityAndCreateOrderLine()
        {
            _viewModel.SelectedProduct = _viewModel.Products.First();
            _viewModel.Quantity.Quantity = 3;
            _viewModel.Quantity.Add.Execute(null);
            Assert.AreEqual(1, _viewModel.OrderLines.Count());
            Assert.AreEqual("Doritos", _viewModel.OrderLines.Single().Name);
            Assert.AreEqual(3, _viewModel.OrderLines.Single().Quantity);
        }

        [TestMethod]
        public void WhenOrderLineIsAdded_QuantityCloses()
        {
            _viewModel.SelectedProduct = _viewModel.Products.First();
            _viewModel.Quantity.Quantity = 3;
            _viewModel.Quantity.Add.Execute(null);

            Assert.IsNull(_viewModel.Quantity);
        }
    }
}
