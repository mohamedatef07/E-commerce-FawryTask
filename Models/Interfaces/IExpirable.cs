namespace Models.Interfaces
{
    public interface IExpirable
    {
        DateTime ExpirationDate { get; }
        bool IsExpired();
    }
}
