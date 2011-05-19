
namespace VendingMachine.Logic.Models
{
    public class OrderLine
    {
        private int _quantity;
        private Product _product;

        public OrderLine(int quantity, Product product)
        {
            _quantity = quantity;
            _product = product;
        }

        public int Quantity
        {
            get { return _quantity; }
        }

        public Product Product
        {
            get { return _product; }
        }
    }
}
