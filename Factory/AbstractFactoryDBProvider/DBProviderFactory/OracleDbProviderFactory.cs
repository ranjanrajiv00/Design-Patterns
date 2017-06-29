using AbstractFactoryDBProvider.AbstractDBProvider;
using AbstractFactoryDBProvider.AbstractFactory;
using AbstractFactoryDBProvider.DBProvider.Oracle;

namespace AbstractFactoryDBProvider.DBProviderFactory
{
    public class OracleDbProviderFactory : IDbProviderFactory
    {
        public IDbCommand CreateCommand()
        {
            return new OracleCommand();
        }

        public IDbConnection CreateConnection()
        {
            return new OracleConnection();
        }
    }
}