namespace AbstractFactoryDBProvider.AbstractDBProvider
{
    public interface IDbConnection
    {
        void Open();

        void Close();
    }
}