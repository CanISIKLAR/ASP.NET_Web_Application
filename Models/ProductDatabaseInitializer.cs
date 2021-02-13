using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace Projecta.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }
        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Deskops"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Laptops"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Mobile Phones"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Tablets"
                },

            };

            return categories;
        }
        private static List<Product> GetProducts()
        {
            var products = new List<Product>
            {
                new Product
                {
                    ProductID = 1,
                    ProductName = "MacBook Pro 2020",
                    Description = "Improved Keyboard comfort,Excellent Retina Display,Four Thunderbolt 3 Ports,Long Battery Life,Good Graphics and Computing Performance",
                    ImagePath = "image/Pro1.jp",
                    UnitPrice = 1999,
                    CategoryID = 2,
                },
                new Product
                {
                    ProductID = 2,
                    ProductName = "iPhone 6S",
                    Description = "Weight 143 g,Retina HD Display with 3D Touch,Fingerprint Sensor Built Into the Home Button,A9 Chip With 64-Bit Architecture,12-Megapixel Camera",
                    ImagePath = "image/sss.jpg",
                    UnitPrice = 300,
                    CategoryID = 3,
                },
                new Product
                {
                    ProductID = 3,
                    ProductName = "ASUS ROG ZEPHYRUS G14",
                    Description = "CPU: AMD Ryzen 7 4800HS – 9 4900HS,RAM: 32GB,GPU: NVIDIA GeForce RTX 2060,Storage: 1TB SSD,AniME Matrix LED display",
                    ImagePath = "image/asus.jpg",
                    UnitPrice = 1699,
                    CategoryID = 2,
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "iPad Pro",
                    Description = "12.9-inch 2732 x 2048 or 11-inch 2388 x 1668 display,A12Z Bionic processor,12MP Wide and 10MP Ultra Wide rear cameras,Edge-to-edge display without Home button,LiDAR depth scanner for AR",
                    ImagePath = "image/ipad_pro.jpg",
                    UnitPrice = 800,
                    CategoryID = 4,
                },
                 new Product
                {
                    ProductID = 5,
                    ProductName = "iPad mini",
                    Description = "8.9-inch 1732 x 1048 or 8-inch 1388 x 665 display,A12Z Bionic processor,8MP Wide and 6MP Ultra Wide rear cameras,Edge-to-edge display with Home button",
                    ImagePath = "image/ipad_pro.jpg",
                    UnitPrice = 399,
                    CategoryID = 4,
                },
                 new Product
                 {
                    ProductID = 6,
                    ProductName = "iPhone XS Max",
                    Description = "Super Retina OLED capacitive touchscreen, 16M colors,120Hz touch-sensing,iOS 12, upgradable to iOS,CPU: Hexa - core(2x2.5 GHz Vortex + 4x1.6 GHz Tempest),GPU: Apple GPU(4 - core graphics) ",
                    ImagePath = "image/xs.jpg",
                    UnitPrice = 900,
                    CategoryID = 3,
                },
                 new Product
                 {
                    ProductID = 7,
                    ProductName = "PS4",
                    Description = "CPU: Intel Celeron 3205U 1.5GHz (dual-core),Graphics: Intel HD Graphics,RAM: 4GB,Storage: 1TB SSD",
                    ImagePath = "image/ps4.jpg",
                    UnitPrice = 449,
                    CategoryID = 1,
                },
                 new Product
                  {
                    ProductID = 8,
                    ProductName = "HP PAVILION 14",
                    Description = "CPU: 8th generation Intel Core i5-8250U,Graphics: Intel UHD Graphics 620,RAM: 8GB,Screen: 14 - inch(1, 920 x 1, 080),Storage: 256GB SSD",
                    ImagePath = "image/hp.jpg",
                    UnitPrice = 679,
                    CategoryID = 2,
                },
                 new Product
                  {
                    ProductID = 9,
                    ProductName = "DELL XPS 13",
                    Description = "CPU: Up to 10th-generation Intel Core i7-1065G7,Graphics: Up to Intel Iris Plus,RAM: Up to 16GB,Screen: 13.4 - inch display,Storage: Up to 1TB",
                    ImagePath = "image/dell.jpg",
                    UnitPrice = 599,
                    CategoryID = 2,
                },




            }; return products;
        }
    }
}