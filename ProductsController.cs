using System.Collections.Generic;
using System.Web.Mvc;
using ProductCatalog.Models;

namespace ProductCatalog.Controllers
{
    public class ProductsController : Controller
    {
        public ActionResult Index()
        {
            List<Products> products = new List<Products>();

            products.Add(new Products
            {
                Id = 1,
                Name = "Mechanical Keyboard",
                Category = "Computer Peripherals",
                Price = 4500,
                Description = "RGB Backlit Mechanical Gaming Keyboard"
            });

            products.Add(new Products
            {
                Id = 2,
                Name = "Ergonomic Office Chair",
                Category = "Furniture",
                Price = 12500,
                Description = "High-back Mesh Chair with Lumbar Support"
            });

            products.Add(new Products
            {
                Id = 3,
                Name = "Noise-Cancelling Earbuds",
                Category = "Audio",
                Price = 6999,
                Description = "Active Noise Cancellation Wireless Earbuds"
            });

            products.Add(new Products
            {
                Id = 4,
                Name = "4K Action Camera",
                Category = "Photography",
                Price = 18500,
                Description = "Waterproof Ultra HD Action Camera"
            });

            products.Add(new Products
            {
                Id = 5,
                Name = "Portable SSD 1TB",
                Category = "Storage",
                Price = 8200,
                Description = "High-speed USB 3.2 External Solid State Drive"
            });

            products.Add(new Products
            {
                Id = 6,
                Name = "Electric Kettle",
                Category = "Home Appliances",
                Price = 1400,
                Description = "1.5L Stainless Steel Rapid Boil Kettle"
            });

            products.Add(new Products
            {
                Id = 7,
                Name = "Desk Pad Mat",
                Category = "Accessories",
                Price = 650,
                Description = "Water-resistant Extended PU Leather Mouse Pad"
            });

            products.Add(new Products
            {
                Id = 8,
                Name = "Studio Condenser Microphone",
                Category = "Audio",
                Price = 5800,
                Description = "Cardioid USB Microphone for Streaming and Podcasting"
            });

            products.Add(new Products
            {
                Id = 9,
                Name = "Smart LED Desk Lamp",
                Category = "Lighting",
                Price = 2200,
                Description = "Dimmable Touch Control Lamp with Wireless Charger"
            });

            products.Add(new Products
            {
                Id = 10,
                Name = "Dual Monitor Arm",
                Category = "Office Accessories",
                Price = 3600,
                Description = "Fully Adjustable Gas Spring Desk Mount"
            });

            return View(products);
        }
    }
}