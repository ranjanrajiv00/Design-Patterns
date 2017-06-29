namespace BankingSystem.Command
{
    public interface ITransaction
    {
        bool IsCompleted { get; set; }

        void Excecute();
    }
}