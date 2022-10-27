using System;

namespace WA3CRUD
{
    public class Products
    {
        //https://learn.microsoft.com/en-us/aspnet/web-api/overview/older-versions/creating-a-web-api-that-supports-crud-operations

        public int ID { get; set; }
        public string Name { get; set; }
        public Manufacturer ManufacturerOfProduct { get; set; }
        public decimal Price { get; set; }
    }
}
