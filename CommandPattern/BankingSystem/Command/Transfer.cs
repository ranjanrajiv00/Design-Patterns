using BankingSystem.Receiver;

namespace BankingSystem.Command
{
    public class Transfer : ITransaction
    {
        private Account fromAccount;
        private Account toAccount;
        private decimal amount;

        public bool IsCompleted { get; set; }

        public Transfer(Account fromAccount, Account toAccount, decimal amount)
        {
            this.fromAccount = fromAccount;
            this.toAccount = toAccount;
            this.amount = amount;
            IsCompleted = false;
        }

        public void Excecute()
        {
            if (fromAccount.Balance >= amount)
            {
                fromAccount.Balance -= amount;
                toAccount.Balance += amount;
                IsCompleted = true;
            }
        }
    }
}