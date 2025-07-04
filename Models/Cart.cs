using Exceptions;

namespace Models
{
    public class Cart
    {
        public List<CartItem> CartItems { get; set; } = new List<CartItem>();

        public void AddToCart(Product product, int quantity)
        {
            if (product == null)
            {
                throw new ArgumentNullException();
            }
            if (quantity > product.Quantity || quantity <= 0)
            {
                throw new OutOfStockException(product.Name);
            }
            CartItems.Add(new CartItem { Product = product, Quantity = quantity });
        }

    }
}
