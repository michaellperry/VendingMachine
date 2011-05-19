using VendingMachine.Logic.Models;

namespace VendingMachine.Logic.ViewModels
{
    public class OrderLineViewModel
    {
        private OrderLine _orderLine;

        public OrderLineViewModel(OrderLine orderLine)
        {
            _orderLine = orderLine;
        }

        public string Name
        {
            get { return _orderLine.Product.Description; }
        }

        public int Quantity
        {
            get { return _orderLine.Quantity; }
        }
    }
}
