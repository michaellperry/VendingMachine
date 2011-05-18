using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingMachine.Logic.Models
{
    public class Product
    {
        private string _description;

        public Product(string description)
        {
            _description = description;
        }

        public string Description
        {
            get { return _description; }
        }
    }
}
