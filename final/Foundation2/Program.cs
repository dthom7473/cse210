public class Program
{
    public static void Main()
    {
        var product1 = new Product("Swim Suit", "13I1TDO4", 19.99m, 1);
        var product2 = new Product("Protein Powder", "39FD9CA3", 29.99m, 2);
        var product3 = new Product("Lotion", "2439VDAD2", 5.99m, 4);
        var product4 = new Product("Canned Soup", "4KDIS9VA", 1.49m, 8);
        var product5 = new Product("Headphones", "98DFAR42", 59.99m, 1);
        var product6 = new Product("Plastic Bags", "9DFAI3JS", 7.99m, 3);

        var address1 = new Address("945 Barkstone Ct", "Salem", "Oregon", "97306", "USA");
        var address2 = new Address("5863 N Arliss Ave", "Fort Frances", "Ontario", "P9A", "Canada");

        var customer1 = new Customer("Rick Bailey", address1);
        var customer2 = new Customer("Andrew Olsen", address2);

        var order1 = new Order(new List<Product> { product1, product2, product3 }, customer1);
        var order2 = new Order(new List<Product> { product4, product5, product6 }, customer2);

        var orders = new List<Order> { order1, order2 };
        foreach (var order in orders)
        {
            Console.WriteLine(order.CreatePackingLabel());
            Console.WriteLine(order.CreateShippingLabel());
            Console.WriteLine($"Total Cost: {order.CalculateTotalCost():C}\n");
        }
    }
}
