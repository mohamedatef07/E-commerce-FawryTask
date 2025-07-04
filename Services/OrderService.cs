using Exceptions;
using Models;
using Models.Interfaces;

namespace Services
{
    public static class OrderService
    {
        private const decimal shippingFees = 30m;
        public static void Checkout(Customer customer, Cart cart)
        {
            if (customer == null || cart == null)
            {
                throw new ArgumentNullException();
            }
            if (!cart.CartItems.Any())
            {
                throw new CartEmptyException();
            }
            foreach (var item in cart.CartItems)
            {
                if (item.Product is IExpirable expirable && expirable.IsExpired())
                {
                    throw new ExpirationException(item.Product.Name);
                }
            }

            decimal subTotal = cart.CartItems.Sum(i => i.Quantity * i.Product.Price);
            var shippables = cart.CartItems.Where(i => i.Product is IShippable).SelectMany(i => Enumerable.Repeat((IShippable)i.Product, i.Quantity)).ToList();
            decimal paidAmount;

            if (shippables.Any())
            {
                paidAmount = shippingFees + subTotal;
            }
            else
            {
                paidAmount = subTotal;
            }

            try
            {
                ShippingService.Ship(shippables);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            customer.DeductBalance(paidAmount);

            Console.WriteLine("** Checkout receipt **");
            foreach (var item in cart.CartItems)
            {
                Console.WriteLine($"{item.Quantity}x {item.Product.Name}     {item.Product.Price * item.Quantity}");
            }
            Console.WriteLine($"---------------------------");
            Console.WriteLine($"SubTotal {subTotal}");
            if (shippables.Any())
            {
                Console.WriteLine($"Shipping {shippingFees}");
            }
            else
            {
                Console.WriteLine($"Shipping 0");
            }
            Console.WriteLine($"Amount {paidAmount}");
            Console.WriteLine($"Remaining Balance {customer.Balance}");
            Console.ReadKey();
        }
    }
}
