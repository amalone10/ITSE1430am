using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayWithLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = GetProducts();

            ///get discounted products
            //var discounted = products.Where(IsDiscounted);
            //expression lambda
            var discounted = products.Where(p => p.IsDiscounted);

            var expensive = products.FirstOrDefault(p => p.Price > 100);

            //statement lambda
            var discountedExpensive = products.Where(p => { return p.IsDiscounted && p.Price > 100; });

            var subsetProducts = products.Select(p => new { Name = p.Name, Price = p.Price });

            var subsetExpensive = subsetProducts.Where(p => p.Price > 100);
        }

        //static bool IsDiscounted ( Product product )
        //{
        //    return product.IsDiscounted;
        //}

        static IEnumerable <Product> GetProducts ()
        {
            return new[]
            {
                new Product() {Name = "product A", Price = 50, IsDiscounted = false},
                new Product() {Name = "product B", Price = 60, IsDiscounted = false},
                new Product() {Name = "product C", Price = 100, IsDiscounted = true},
                new Product() {Name = "product D", Price = 10, IsDiscounted = false},
                new Product() {Name = "product E", Price = 45, IsDiscounted = false},
                new Product() {Name = "product F", Price = 350, IsDiscounted = true},
                new Product() {Name = "product G", Price = 90, IsDiscounted = true},
                new Product() {Name = "product H", Price = 75, IsDiscounted = true},
                new Product() {Name = "product I", Price = 65, IsDiscounted = false},
                new Product() {Name = "product J", Price = 250, IsDiscounted = false},
                new Product() {Name = "product K", Price = 30, IsDiscounted = false},
            };
        }
    }

    class Product
    {
        public string Name { get; set; }
        public bool IsDiscounted { get; set; }
        public decimal Price { get; set; }
    }
}
