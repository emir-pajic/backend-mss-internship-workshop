using DI.Demo.Model;
using System.Collections.Generic;

namespace DI.Demo.Services
{
    public class ProductsService
    {
        public ProductsService()
        {

        }

        public List<Product> GetProductsFromDatabase()
        {
            return new List<Product>()
            {
                new Product()
                {
                    ProductId = 1,
                    Name = "HP Laptop xxx",
                    Type = "Computer device",
                    Price = 1399
                },
                new Product()
                {
                    ProductId = 2,
                    Name = "Monitor 240hz",
                    Type = "Monitor",
                    Price = 600
                },
                new Product()
                {
                    ProductId = 3,
                    Name = "Razor Gaming Mouse",
                    Type = "Mouse",
                    Price = 200
                },
                new Product()
                {
                    ProductId = 4,
                    Name = "Gaming Keyboard",
                    Type = "Keyboard",
                    Price = 1399
                },
                new Product()
                {
                    ProductId = 5,
                    Name = "Ultra bass headset",
                    Type = "SoundSystem",
                    Price = 50
                }
            };           
        }
        public Product GetProductById(int id)
        {
            var products = GetProductsFromDatabase();

            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].ProductId == id)
                {
                    return products[i];
                }
            }
            return new Product();
        }
    }
}
