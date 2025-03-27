class Program
{
    static void Main()
    {
        // Create some products
        Product product1 = new Product("Laptop", "P1001", 800, 1);
        Product product2 = new Product("Mouse", "P2002", 25, 2);
        Product product3 = new Product("Keyboard", "P3003", 50, 1);
        Product product4 = new Product("Monitor", "P4004", 200, 1);
        Product product5 = new Product("Headphones", "P5005", 50, 3);
        Product product6 = new Product("Webcam", "P6006", 75, 4);

        // Create a customer and their address
        Address usaAddress = new Address("123", "Main St", "New York", "NY", "10001", "USA");
        Customer customer1 = new Customer("John Doe", usaAddress);
        Address canadaAddress = new Address("456", "First St", "Toronto", "ON", "M1M1M1", "Canada");
        Customer customer2 = new Customer("Jane Doe", canadaAddress);

        // Create an order for the customer with a list of products
        List<Product> order1Products = new List<Product> { product1, product2, product3 };
        Order order1 = new Order(order1Products, customer1);
        List<Product> order2Products = new List<Product> { product4, product5, product6 };
        Order order2 = new Order(order2Products, customer2);

        // Output the results
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalPrice()}");
        Console.WriteLine();
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalPrice()}");
    }
}