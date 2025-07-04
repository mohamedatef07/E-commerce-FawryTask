namespace Models.Products
{
    public class TV : ShippableProduct
    {
        public TV(string _name, decimal _price, int _quantity, double _weight)
        {
            Name = _name;
            Price = _price;
            Quantity = _quantity;
            Weight = _weight;
        }
    }
}
