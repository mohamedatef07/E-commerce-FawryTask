using Models.Interfaces;

namespace Models
{
    public class ShippableProduct : Product, IShippable
    {
        public double Weight { get; set; }
        public string getName()
        {
            return Name;
        }

        public double getWeight()
        {
            return Weight;
        }
    }
}
