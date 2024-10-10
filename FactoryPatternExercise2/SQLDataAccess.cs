using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    internal class SQLDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
                new Product() { Name = "CPU", Price = 129.99m },
                new Product() { Name = "GPU", Price = 599.99m },
                new Product() { Name = "Motherboard", Price = 199.99m},
                new Product() { Name = "Keyboard", Price = 120.99m },
                new Product() { Name = "Monitor", Price = 159.99m },
                new Product() { Name = "Mouse", Price = 65.99m },
                new Product() { Name = "Desk", Price = 250.99m },
                new Product() { Name = "Power Supply", Price = 120.99m }
        };

        public List<Product> LoadData()
        {
            Console.WriteLine($"I am reading data from a List database.");

            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine($"I am saving data to a SQL database.");
        }
    }
}
