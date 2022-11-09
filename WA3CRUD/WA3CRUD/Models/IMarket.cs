using System.Collections.Generic;

namespace WA3CRUD.Models
{
    public interface IMarket
    {
        IEnumerable<Product> GetAll();
        Product Get(string id);
        Product Add(Product item);
        void Remove(string id);
        bool Update(Product item);
    }
}
