using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingMachine.Logic.Models
{
    public class Catalog
    {
        private List<Product> _products = new List<Product>();

        public Catalog AddProduct(string description)
        {
            _products.Add(new Product(description));
            return this;
        }

        public IEnumerable<Product> Products
        {
            get { return _products; }
        }
    }
}
