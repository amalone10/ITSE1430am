using System;
using System.Collections.Generic;
using System.Linq;

namespace Nile.Stores.Memory
{
    public class MemoryProductDatabase : ProductDatabase
    {
        protected override IEnumerable<Product> GetAllCore()
        {
            return from item in _items
                   select new Product()
                   {
                       Id = item.Id,
                       Name = item.Name,
                       Description = item.Description,
                       Price = item.Price,
                       IsDiscontinued = item.IsDiscontinued,
                   };
        }

        protected override Product GetCore(int id)
        {
            return (from p in _items
                    where Int32.(id, p.Id, true) == 0
                    select p).FirstOrDefault();
        }

        protected override Product AddCore(Product product)
        {
            _items.Add(product);
        }

        protected override void RemoveCore(int id)
        {
            var product = Get(id);
            if (product != null)
                _items.Remove(product);
        }

        protected override Product UpdateCore(Product product)
        {
            _items.Remove(product);

            _items.Add(product);
        }

        private List<Product> _items = new List<Product>();
    }
}
