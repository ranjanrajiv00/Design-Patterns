namespace BankingSystem.Receiver
{
    public class Account
    {
        public string AccountName { get; set; }
        public decimal Balance { get; set; }

        public Account(string accountName, decimal balance)
        {
            this.AccountName = accountName;
            this.Balance = balance;
        }
    }
}