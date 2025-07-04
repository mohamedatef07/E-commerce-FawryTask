namespace Models.Products
{
    public class Cheese : ExpirableShippableProduct
    {
        public Cheese(string _name, decimal _price, int _quantity, double _weight, DateTime _expirationDate)
        {
            Name = _name;
            Price = _price;
            Quantity = _quantity;
            Weight = _weight;
            ExpirationDate = _expirationDate;
        }
    }
}
