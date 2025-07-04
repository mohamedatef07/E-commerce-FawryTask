namespace Models.Products
{
    public class Biscuits : ExpirableProduct
    {
        public Biscuits(string _name, decimal _price, int _quantity, DateTime _expirationDate)
        {
            Name = _name;
            Price = _price;
            Quantity = _quantity;
            ExpirationDate = _expirationDate;
        }
    }
}
