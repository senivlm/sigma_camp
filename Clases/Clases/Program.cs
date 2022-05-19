using System;

namespace Clases
{

    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Weight { get; set; } 
        
        public Product (string name,double price, double weight )
        {
            Name = name;
            Price = price;
            Weight = weight;
        }
    }

    public class Buy
    {
        public int Count { get; set; } 
        public double SummaryPrice { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
