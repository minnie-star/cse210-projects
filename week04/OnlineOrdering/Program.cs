using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Address address = new Address("123 Bool St", "Los Angeles", "CA", "USA");
        Customer customer = new Customer("James", address);

        Order order = new Order(customer);
        order.AddProduct(new Product("Laptop", 111, 1276, 1));
        order.AddProduct(new Product("Notebook", 105, 45, 3));
        order.AddProduct(new Product("Perfume", 125, 189, 2));

        Console.WriteLine("Packing Label:\n" + order.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order.GetShippingLabel());
        Console.WriteLine("Total Price:\n" + order.CalculateTotalPrice());
        
        // second order outside USA
        Address address2 = new Address("144 Colber St", "Sandton", "JHB", "RSA");
        Customer customer2 = new Customer("Sam", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("TV", 132, 2345, 1));
        order2.AddProduct(new Product("Iphone", 145, 600, 1));
        order2.AddProduct(new Product("Monitor", 124, 432, 2));

        Console.WriteLine("Packing Label:\n" + order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order2.GetShippingLabel());
        Console.WriteLine("Total Price:\n" + order2.CalculateTotalPrice());
    }
}