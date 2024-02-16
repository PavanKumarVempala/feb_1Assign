// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        SortedList<string, Product> products = new SortedList<string, Product>();

        
        products.Add("Keyboard", new Product("Keyboard", 20.99, "Logitech", new DateTime(2023, 1, 15), new DateTime(2026, 1, 15)));
        products.Add("Mouse", new Product("Mouse  ", 12.50, "Microsoft", new DateTime(2023, 2, 10), new DateTime(2026, 2, 10)));
        products.Add("Monitor", new Product("Monitor", 199.99, "Dell", new DateTime(2023, 3, 20), new DateTime(2027, 3, 20)));
        products.Add("Laptop", new Product("Laptop ", 699.99, "HP", new DateTime(2023, 4, 25), new DateTime(2027, 4, 25)));
        products.Add("Headphone", new Product("Headphone", 49.99, "Sony", new DateTime(2023, 5, 30), new DateTime(2026, 5, 30)));

        
        Console.WriteLine("Index \t\t PName \t\t Price \t\t Brand \t\t MfDate \t\t ExpDate");
        foreach (var product in products)
        {
            Console.WriteLine($"{products.IndexOfKey(product.Key) + 1} \t\t{product.Value}");
        }
    }
}

class Product
{
    public string PName { get; set; }
    public double PPrice { get; set; }
    public string PBrand { get; set; }
    public DateTime ManufacturingDate { get; set; }
    public DateTime ExpiryDate { get; set; }

    public Product(string name, double price, string brand, DateTime mfDate, DateTime expDate)
    {
        PName = name;
        PPrice = price;
        PBrand = brand;
        ManufacturingDate = mfDate;
        ExpiryDate = expDate;
    }

    public override string ToString()
    {
        return $"{PName} \t\t {PPrice} \t\t {PBrand} \t\t {ManufacturingDate.ToShortDateString()} \t\t {ExpiryDate.ToShortDateString()}";
    }
}
