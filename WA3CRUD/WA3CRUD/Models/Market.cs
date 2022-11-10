using System;
using System.Collections.Generic;

namespace WA3CRUD.Models
{
    public class Market : IMarket
    {
        private static List<Product> products = new List<Product>();
        
        public Market()
        {
            Add(new Product {Name = "RedMi", ManufacturerOfProduct = new Manufacturer("China", "XIAOMI"), Price = 500});
            Add(new Product {Name = "Galaxy Note", ManufacturerOfProduct = new Manufacturer("Korea", "Samsung"), Price = 700});
            Add(new Product {Name = "Iphone", ManufacturerOfProduct = new Manufacturer("USA", "Apple"), Price = 1000});
            Add(new Product {Name = "Galaxy S", ManufacturerOfProduct = new Manufacturer("Korea", "Samsung"), Price = 750 });
            Add(new Product {Name = "MI", ManufacturerOfProduct = new Manufacturer("China", "XIAOMI"), Price = 650});
            Add(new Product {Name = "ZenPhone", ManufacturerOfProduct = new Manufacturer("China", "ASUS"), Price = 650 });
        }

        public IEnumerable<Product> GetAll()
        {
            return products;
        }

        public Product Get(string id)
        {
            return products.Find(p => p.ID == id);
        }

        public Product Add(Product item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            item.ID = Guid.NewGuid().ToString();
            products.Add(item);
            return item;
        }

        public void Remove(string id)
        {
            products.RemoveAll(p => p.ID == id);
        }

        public bool Update(Product item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            int index = products.FindIndex(p => p.ID == item.ID);
            if (index == -1)
            {
                return false;
            }
            products.RemoveAt(index);
            products.Add(item);
            return true;
        }
    }
}
