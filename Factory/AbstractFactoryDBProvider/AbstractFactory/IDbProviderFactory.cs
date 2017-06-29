using AbstractFactoryDBProvider.AbstractDBProvider;

namespace AbstractFactoryDBProvider.AbstractFactory
{
    public interface IDbProviderFactory
    {
        IDbConnection CreateConnection();

        IDbCommand CreateCommand();
    }
}