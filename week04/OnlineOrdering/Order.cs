using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // ==================================
        // FIRST ORDER - USA CUSTOMER
        // ==================================

        // Create the customer's address.
        Address address1 = new Address(
            "123 Main Street",
            "Dallas",
            "Texas",
            "USA"
        );

        // Create the customer.
        Customer customer1 = new Customer(
            "John Smith",
            address1
        );

        // Create products.
        Product product1 = new Product(
            "Laptop",
            "LAP101",
            750.00m,
            1
        );

        Product product2 = new Product(
            "Wireless Mouse",
            "MOU102",
            25.00m,
            2
        );

        Product product3 = new Product(
            "Keyboard",
            "KEY103",
            40.00m,
            1
        );

        // Create the first order.
        Order order1 = new Order(customer1);

        // Add products to the first order.
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);


        // ==================================
        // SECOND ORDER - INTERNATIONAL CUSTOMER
        // ==================================

        // Create the customer's address.
        Address address2 = new Address(
            "45 King Street",
            "Toronto",
            "Ontario",
            "Canada"
        );

        // Create the customer.
        Customer customer2 = new Customer(
            "David Johnson",
            address2
        );

        // Create products.
        Product product4 = new Product(
            "Smartphone",
            "PHO201",
            600.00m,
            1
        );

        Product product5 = new Product(
            "Headphones",
            "HEA202",
            80.00m,
            2
        );

        Product product6 = new Product(
            "Phone Case",
            "CAS203",
            15.00m,
            3
        );

        // Create the second order.
        Order order2 = new Order(customer2);

        // Add products to the second order.
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);


        // ==================================
        // DISPLAY ORDER INFORMATION
        // ==================================

        Console.WriteLine("ONLINE ORDERING SYSTEM");
        Console.WriteLine("======================");

        // Display first order.
        Console.WriteLine("\nORDER 1");
        Console.WriteLine("----------------------");

        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine(
            $"Total Order Cost: ${order1.GetTotalCost():F2}"
        );

        // Display second order.
        Console.WriteLine("\nORDER 2");
        Console.WriteLine("----------------------");

        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine(
            $"Total Order Cost: ${order2.GetTotalCost():F2}"
        );
    }
}