using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order();
        order1.SetName("Annika Gosney");
        order1.SetAddress("111 Candy Ln", "Elf Factory", "Santa Land", "Antarctica");

        Product product1 = new Product("Toy", "1", 8.42, 9);
        Product product2 = new Product("Sled", "2", 12.53, 2);
        Product product3 = new Product("Hot Chocolate", "3", 2.53, 100);

        order1.AddList(product1);
        order1.AddList(product2);
        order1.AddList(product3);

        Order order2 = new Order();
        order2.SetName("David Gosney");
        order2.SetAddress("111 BYUI Dr", "Rexburg", "Idaho", "United States");

        Product product4 = new Product("Laptop", "4", 1059.99, 1);
        Product product5 = new Product("Monitor", "5", 210.99, 1);
        Product product6 = new Product("Earbuds", "6", 43.99, 1);

        order2.AddList(product4);
        order2.AddList(product5);
        order2.AddList(product6);

        Console.WriteLine("Order 1:");
        Console.WriteLine($"Packing Label\n{order1.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label:\n{order1.GetShippingLabel()}");
        Console.WriteLine($"\nTotal: ${order1.GetTotal()}");
        Console.WriteLine("\n");
        Console.WriteLine("Order 2:");
        Console.WriteLine($"Packing Label\n{order2.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label:\n{order2.GetShippingLabel()}");
        Console.WriteLine($"\nTotal: ${order2.GetTotal()}");
        Console.WriteLine("\n");
    }
}