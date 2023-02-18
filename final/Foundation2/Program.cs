using System;

class Program
{
    static void Main(string[] args)
    {
        // Write a program that creates at least two orders with a 2-3 products each. 
        // Call the methods to get the:
        // packing label, the shipping label, and the total price of the order
        // Display the results of these methods.
        
        Console.WriteLine("*** Order System ***\n");
        Console.WriteLine("Let's place an order!\n");

        Product shoes = new Product("Clog Shoes", 109432432, 55, 1);
        Product jeans = new Product("Lucky Jeans", 103234323, 35, 2);
        Product shirt = new Product("White Cotton Shirt", 10134289, 25, 3);
        Product socks = new Product("White socks", 109234332, 5, 4);
        Product watch = new Product("Zazoo Watch", 105234098, 50, 1);

        List<Product> order1Products = new List<Product>();

        order1Products.Add(shoes);
        order1Products.Add(jeans);
        order1Products.Add(socks);

        List<Product> order2Products = new List<Product>();

        order2Products.Add(watch);
        order2Products.Add(shirt);

        Address address = new Address("12 Laurel St.", "Queen Creek", "AZ", "USA");
        Customer customer = new Customer("Mary Smith", address);

        Order order1 = new Order(customer, order1Products);

        order1.displayShippingLabel();
        order1.displayPackingLabels(order1.getPackingLabels());
        order1.displayOrderTotal();

        Order order2 = new Order(customer, order2Products);

        order2.displayShippingLabel();
        order2.displayPackingLabels(order2.getPackingLabels());
        order2.displayOrderTotal();

        

        
    }
}