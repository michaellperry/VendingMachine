using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UpdateControls.Collections;

namespace VendingMachine.Logic.Models
{
    public class Order
    {
        private IndependentList<OrderLine> _orderLines = new IndependentList<OrderLine>();

        public void AddOrderLine(int quantity, Product product)
        {
            _orderLines.Add(new OrderLine(quantity, product));
        }

        public IEnumerable<OrderLine> OrderLines
        {
            get { return _orderLines; }
        }
    }
}
