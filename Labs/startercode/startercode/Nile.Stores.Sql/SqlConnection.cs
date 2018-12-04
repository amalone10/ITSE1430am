namespace Nile.Stores.Sql
{
    internal class SqlConnection
    {
        private string _connectionString;

        public SqlConnection(string connectionString)
        {
            _connectionString = connectionString;
        }
    }
}