using AbstractFactoryDBProvider.AbstractDBProvider;
using AbstractFactoryDBProvider.AbstractFactory;
using AbstractFactoryDBProvider.DBProvider.SQL;

namespace AbstractFactoryDBProvider.DBProviderFactory
{
    public class SqlDbProviderFactory : IDbProviderFactory
    {
        public IDbCommand CreateCommand()
        {
            return new SqlCommand();
        }

        public IDbConnection CreateConnection()
        {
            return new SqlConnection();
        }
    }
}