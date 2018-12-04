using System;
using System.Collections.Generic;

namespace Nile.Stores.Sql
{
    public class SqlProductDatabase : ProductDatabase
    {
        public SqlProductDatabase (string connectionString)
        {
            if (connectionString == null)
                throw new ArgumentNullException(nameof(connectionString));
            if (connectionString == "")
                throw new ArgumentException("Connection string cannot be empty.", nameof(connectionString));

            _connectionString = connectionString;
        }

        protected override Product AddCore(Product product)
        {

        }

        protected override IEnumerable<Product> GetAllCore()
        {
            throw new NotImplementedException();
        }

        protected override Product GetCore(int id)
        {
            throw new NotImplementedException();
        }

        protected override void RemoveCore(int id)
        {
            throw new NotImplementedException();
        }

        protected override Product UpdateCore(Product existing, Product newItem)
        {
            throw new NotImplementedException();
        }

        private SqlConnection CreateConnection() => new SqlConnection(_connectionString);

        private readonly string _connectionString;
    }
}
