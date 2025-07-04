using Models.Interfaces;

namespace Models
{
    public class ExpirableProduct : Product, IExpirable
    {
        public DateTime ExpirationDate { get; set; }

        public bool IsExpired()
        {
            return ExpirationDate < DateTime.UtcNow;
        }
    }
}
