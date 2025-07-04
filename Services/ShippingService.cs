using Models.Interfaces;

namespace Services
{
    public static class ShippingService
    {
        public static void Ship(List<IShippable> shippables)
        {
            if (shippables == null || !shippables.Any())
            {
                throw new ArgumentNullException(nameof(shippables));
            }
            Console.WriteLine("** Shipment notice **");
            var shippableGrouped = shippables.GroupBy(i => i.getName());
            double totalWeight = 0;
            foreach (var group in shippableGrouped)
            {
                int count = group.Count();
                double weight = group.Sum(i => i.getWeight());
                totalWeight += weight;
                Console.WriteLine($"{count}x {group.Key} {(weight * 1000).ToString("f2")}g");
            }
            Console.WriteLine($"Total Package Weight {totalWeight.ToString("f2")}kg");
        }
    }
}
