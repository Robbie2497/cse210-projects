using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("1757 Burke Rd.", "Logan", "UT", "USA");
        Address address2 = new Address("Cercas Bajas 52", "08000", "Barcelona", "Spain");
        List<Product> products1 = new List<Product>();
        List<Product> products2 = new List<Product>();
        Product product1 = new Product(1, "iPad Air", 599.99, 2);
        Product product2 = new Product(2, "Airpods Pro II", 199.99, 2);
        products1.Add(product1);
        products1.Add(product2);

        Product product3 = new Product(3, "Nike Running Shoes", 79.99, 1);
        Product product4 = new Product(4, "Men's Long Socks", 2.99, 5);
        Product product5 = new Product(5, "Fabuloso Cleaner", 19.99, 1);
        products2.Add(product3);
        products2.Add(product4);
        products2.Add(product5);

        Customer customer1 = new Customer("Grace", address1);
        Order order1 = new Order(products1, customer1);
        Console.Clear();
        Console.WriteLine("---------------------------------------------------------------------------");
        Console.WriteLine("ORDER #1");
        Console.WriteLine("---------------------------------------------------------------------------");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();
        double total1 = order1.GetOrderCost();
        Console.WriteLine($"Order total: ${total1}");
        Console.WriteLine();

        Console.WriteLine("---------------------------------------------------------------------------");
        Console.WriteLine("ORDER #2");
        Console.WriteLine("---------------------------------------------------------------------------");

        Customer customer2 = new Customer("Pedro Martinez", address2);
        Order order2 = new Order(products2, customer2);
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();
        double total2 = order2.GetOrderCost();
        Console.WriteLine($"Order total: ${total2}");
    }
}