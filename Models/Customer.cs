using Exceptions;

namespace Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public decimal Balance { get; set; }

        public void DeductBalance(decimal amount)
        {
            if (Balance < amount)
            {
                throw new InsufficientBalanceException();
            }
            Balance -= amount;
        }
        public Customer(int _customerId, string _fullName, string _address, decimal _balance)
        {
            CustomerId = _customerId;
            FullName = _fullName;
            Address = _address;
            Balance = _balance;
        }
    }
}
