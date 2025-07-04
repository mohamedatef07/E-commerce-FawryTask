using Models;
using Models.Products;
using Services;

namespace Presentation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rumiCheese = new Cheese("Rumi Cheese", 100m, 70, 1.6, DateTime.UtcNow.AddDays(7));
            var tv = new TV("TV", 500m, 23, 100);
            var biscuits = new Biscuits("Tommor", 10m, 200, DateTime.UtcNow.AddDays(3));

            var customer = new Customer(1, "Mohamed Atef", "Cairo", 100000m);
            var cart = new Cart();

            try
            {
                cart.AddToCart(rumiCheese, 10);
                cart.AddToCart(tv, 20);
                cart.AddToCart(biscuits, 20);
                OrderService.Checkout(customer, cart);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            #region Out of stock examples
            //var rumiCheese = new Cheese("Rumi Cheese", 100m, 70, 1.6, DateTime.UtcNow.AddDays(7));
            //var tv = new TV("TV", 500m, 23, 100);
            //var biscuits = new Biscuits("Tommor", 10m, 200, DateTime.UtcNow.AddDays(3));

            //var customer = new Customer(1, "Mohamed Atef", "Cairo", 100m);
            //var cart = new Cart();

            //try
            //{
            //    cart.AddToCart(rumiCheese, 10);
            //    cart.AddToCart(tv, 20);
            //    cart.AddToCart(biscuits, 202);
            //    OrderService.Checkout(customer, cart);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}
            #endregion

            #region Expiration examples
            //var rumiCheese = new Cheese("Rumi Cheese", 100m, 70, 1.6, DateTime.UtcNow.AddDays(-30));
            //var tv = new TV("TV", 500m, 23, 100);
            //var biscuits = new Biscuits("Tommor", 10m, 200, DateTime.UtcNow.AddDays(3));

            //var customer = new Customer(1, "Mohamed Atef", "Cairo", 100m);
            //var cart = new Cart();

            //try
            //{
            //    cart.AddToCart(rumiCheese, 10);
            //    cart.AddToCart(tv, 20);
            //    cart.AddToCart(biscuits, 20);
            //    OrderService.Checkout(customer, cart);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}
            #endregion

            #region Insufficient Balance examples
            //var rumiCheese = new Cheese("Rumi Cheese", 100m, 70, 1.6, DateTime.UtcNow.AddDays(7));
            //var tv = new TV("TV", 500m, 23, 100);
            //var biscuits = new Biscuits("Tommor", 10m, 200, DateTime.UtcNow.AddDays(3));

            //var customer = new Customer(1, "Mohamed Atef", "Cairo", 100m);
            //var cart = new Cart();

            //try
            //{
            //    cart.AddToCart(rumiCheese, 10);
            //    cart.AddToCart(tv, 20);
            //    cart.AddToCart(biscuits, 20);
            //    OrderService.Checkout(customer, cart);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}
            #endregion

            #region Cart Empty examples
            //var rumiCheese = new Cheese("Rumi Cheese", 100m, 70, 1.6, DateTime.UtcNow.AddDays(7));
            //var tv = new TV("TV", 500m, 23, 100);
            //var biscuits = new Biscuits("Tommor", 10m, 200, DateTime.UtcNow.AddDays(3));

            //var customer = new Customer(1, "Mohamed Atef", "Cairo", 100m);
            //var cart = new Cart();

            //try
            //{
            //    OrderService.Checkout(customer, cart);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}
            #endregion

        }
    }
}

