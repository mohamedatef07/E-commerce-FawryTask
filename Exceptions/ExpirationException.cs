namespace Exceptions
{
    public class ExpirationException : BaseException
    {
        public ExpirationException(string product) : base($"Product '{product}' is expired")
        {
        }
    }
}
