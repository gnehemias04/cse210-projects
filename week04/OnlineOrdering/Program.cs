using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("Tilton st", "Filadelfia", "Pensilvania", "United States");
        Customer customer1 = new Customer("David Walker", address1);
        Order order1 = new Order(customer1);
        Product product1 = new Product("Coffee", 101, 5, 1);
        Product product2 = new Product("Milk", 102, 4, 3);
        Product product3 = new Product("Chocolatte", 103, 6, 1);
        Product product4 = new Product("Chess", 105, 2, 4);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);
        order1.AddProduct(product4);

        Address address2 = new Address("Juan B Alberdi", "Villa San Martin", "Santiago del Estero", "Argentina");
        Customer customer2 = new Customer("Lucas Rodriguez", address2);
        Order order2 = new Order(customer2);
        Product productA = new Product("Coffee", 101, 5, 3);
        Product productB = new Product("Tomatto", 109, 2, 4);
        Product productC = new Product("Orange", 107, 2, 5);
        Product productD = new Product("Onnion", 110, 3, 1);
        order2.AddProduct(productA);
        order2.AddProduct(productB);
        order2.AddProduct(productC);
        order2.AddProduct(productD);

        Address address3 = new Address("R Ibirairas", "Guarulhos", "Sao Paulo", "Brasil");
        Customer customer3 = new Customer("Ruan Monte", address3);
        Order order3 = new Order(customer3);
        Product productE = new Product("Milk", 102, 4, 2);
        Product productF = new Product("Tomatto", 109, 2, 1);
        Product productG = new Product("Flour", 111, 2, 4);
        Product productH = new Product("Juice", 112, 1, 1);
        order3.AddProduct(productE);
        order3.AddProduct(productF);
        order3.AddProduct(productG);
        order3.AddProduct(productH);


        Console.WriteLine(order1.GetOrder());
        Console.WriteLine(order2.GetOrder());
        Console.WriteLine(order3.GetOrder());

    }
}