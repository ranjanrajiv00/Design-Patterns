using BankingSystem.Receiver;

namespace BankingSystem.Command
{
    public class Withdraw : ITransaction
    {
        private Account account;
        private decimal amount;

        public Withdraw(Account account, decimal amount)
        {
            this.account = account;
            this.amount = amount;
            IsCompleted = false;
        }

        public bool IsCompleted { get; set; }

        public void Excecute()
        {
            if (account.Balance >= amount)
            {
                account.Balance -= amount;
                IsCompleted = true;
            }
        }
    }
}