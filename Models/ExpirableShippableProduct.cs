using Models.Interfaces;

namespace Models
{
    public class ExpirableShippableProduct : Product, IExpirable, IShippable
    {
        public double Weight { get; set; }

        public DateTime ExpirationDate { get; set; }

        public string getName()
        {
            return Name;
        }

        public double getWeight()
        {
            return Weight;
        }

        public bool IsExpired()
        {
            return ExpirationDate < DateTime.UtcNow;
        }
    }
}
