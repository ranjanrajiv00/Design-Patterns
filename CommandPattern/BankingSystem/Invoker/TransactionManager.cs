using BankingSystem.Command;
using System.Collections.Generic;
using System.Linq;

namespace BankingSystem.Invoker
{
    public class TransactionManager
    {
        private List<ITransaction> _transactions = new List<ITransaction>();

        public bool HasPendingTransactions
        {
            get
            {
                return _transactions.Any(x => !x.IsCompleted);
            }
        }

        public void AddTransaction(ITransaction transaction)
        {
            _transactions.Add(transaction);
        }

        public void ProcessPendingTransactions()
        {
            foreach (var transaction in _transactions.Where(x => !x.IsCompleted))
            {
                transaction.Excecute();
            }
        }
    }
}