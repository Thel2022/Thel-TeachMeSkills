using System.Collections.Generic;

namespace WA3CRUD.Models
{
    public interface IMarketable
    {
        IEnumerable<Product> GetAll();
        Product Get(int id);
        Product Add(Product item);
        void Remove(int id);
        bool Update(Product item);
    }
}
