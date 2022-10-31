using System;

namespace WA3CRUD
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Manufacturer ManufacturerOfProduct { get; set; }
        public decimal Price { get; set; }
    }
}
