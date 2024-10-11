using System;

class Program
{
    static void Main(string[] args)
    {
        //create address
        Address address1 = new Address("123 Street", "Winter Park", "Florida", "USA" );
        Address address2 = new Address("456 Street", "Karuhatan", "Valenzuela", "PH");
        Address address3 = new Address("789 Street", "Dunedin", "Otago", "NZ");

        //create customer list
        Customer customer1 = new Customer("Harry Potter", address1);
        Customer customer2 = new Customer("Rain Showers", address2);
        Customer customer3 = new Customer("Peter Pan", address3);
        
        //add products to List
        Product product1 = new Product($"bluetooth keyboard", "MX7188", 68.50, 20);
        Product product2 = new Product("bar speaker","ABL405X", 118.39, 5);
        Product product3 = new Product("iPhone 16 Pro Max", "MQFJ3CH/A", 1899, 25);
        Product product4 = new Product("DJI Mini 4 Pro", "DCX-8991A", 899.99, 10);
        Product product5 = new Product("42' flatscreen","LGT00111-X87",895.56,30);

        //create list for each order
        List<Product> orderList1 = new List<Product> {product1, product2, product5};
        List<Product> orderList2 = new List<Product> {product3, product4};
        List<Product> orderList3 = new List<Product> {product1, product2, product3};
        
        //create orders 1 and 2, it has product list, packing label, shipping label, total price
        Order order1 = new Order(orderList1,customer1, 5, 35);
        Order order2 = new Order(orderList2, customer2, 5, 35);
        Order order3 = new Order(orderList3, customer3, 5, 35);

        //order1
        Console.WriteLine("Order Details - Order #0001");
        Console.WriteLine(DateTime.Now);
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Order: ${order1.GetTotalCost()}");
        Console.WriteLine($"Shipping Fee: ${order1.GetShippingFee()}");
        Console.WriteLine($"Grand Total: ${order1.GetFinalCost():F2}\n");
        Console.WriteLine("-------------------------------------------\n");
         //order2
        Console.WriteLine("Order Details - Order #0002");
        Console.WriteLine(DateTime.Now);
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Order: ${order2.GetTotalCost()}");
        Console.WriteLine($"Shipping Fee: ${order2.GetShippingFee()}");
        Console.WriteLine($"Grand Total: ${order2.GetFinalCost():F2}\n");
        Console.WriteLine("-------------------------------------------\n");
        //order3
        Console.WriteLine("Order Details - Order #0003");
        Console.WriteLine(DateTime.Now);
        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine($"Total Order: ${order3.GetTotalCost()}");
        Console.WriteLine($"Shipping Fee: ${order3.GetShippingFee()}");
        Console.WriteLine($"Grand Total: ${order3.GetFinalCost():F2}\n");
        Console.WriteLine("-------------------------------------------\n");
    }
}