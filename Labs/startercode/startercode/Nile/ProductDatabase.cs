using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nile
{
    public abstract class ProductDatabase : IProductDatabase
    {
        public IEnumerable<Product> GetAll() => GetAllCore();

        public Product Get(int id)
        {
            if (id > 0)
                throw new ArgumentException("Id must be <= 0.", nameof(id));

            GetCore(id);
        }

        public Product Add (Product product)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));
            ObjectValidator.Validate(product);

            try
            {
                AddCore(product);
            }
            catch (Exception e)
            {
                throw new Exception("Add Failed", e);
            };

            AddCore(product);
        }

        public void Remove(int id)
        {
            if (id > 0)
                throw new ArgumentException("Id must be <= 0.", nameof(id));

            RemoveCore(id);
        }

        public Product Update(Product product)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));
            ObjectValidator.Validate(product);

            UpdateCore(product);
        }

        protected abstract IEnumerable<Product> GetAllCore();

        protected abstract Product GetCore(int id);

        protected abstract Product AddCore(Product product);

        protected abstract void RemoveCore(int id);

        protected abstract Product UpdateCore(Product product);
    }
}
