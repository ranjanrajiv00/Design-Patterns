using BankingSystem.Receiver;

namespace BankingSystem.Command
{
    public class Deposit : ITransaction
    {
        private Account account;
        private decimal amount;
        public bool IsCompleted { get; set; }

        public Deposit(Account account, decimal amount)
        {
            this.account = account;
            this.amount = amount;
            IsCompleted = false;
        }

        public void Excecute()
        {
            account.Balance += amount;
            IsCompleted = true;
        }
    }
}