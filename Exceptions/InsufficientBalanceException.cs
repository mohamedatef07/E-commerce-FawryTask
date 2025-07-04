namespace Exceptions
{
    public class InsufficientBalanceException : BaseException
    {
        public InsufficientBalanceException() : base("Insufficient balance")
        {
        }
    }
}
