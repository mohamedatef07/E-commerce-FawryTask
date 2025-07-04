namespace Exceptions
{
    public class OutOfStockException : BaseException
    {
        public OutOfStockException(string product) : base($"Product '{product}' is out of stock")
        {

        }
    }
}
