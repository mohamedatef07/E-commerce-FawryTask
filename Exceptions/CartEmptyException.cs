namespace Exceptions
{
    public class CartEmptyException : BaseException
    {
        public CartEmptyException() : base($"Car is empty")
        {

        }
    }
}
