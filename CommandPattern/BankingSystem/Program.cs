using BankingSystem.Command;
using BankingSystem.Invoker;
using BankingSystem.Receiver;
using System;

namespace BankingSystem
{
    /*
     Sometimes, you don’t want to do execute your functions immediately.
     You can use the Command pattern to add work to a queue, to be done later.
     You can use it to retry, if a command cannot execute properly.
     You might be able to use this to add “undo” capabilities to a program.

    Parts of the Command Design Pattern

    There are four parts to the Command pattern.

    Command: Classes that execute an action (perform a function).

    Receiver: Business objects that “receive” the action from the Command.

    Invoker: This class tells the Commands to execute their actions. The Invoker can sometimes be a queue (when it holds commands to be executed later), a pool (when it holds commands that can be executed by different programs/computers), or let you do more things with your commands (retry failed commands, undo commands that were executed, etc.)

    Client: The main program that uses the other parts.
     */

    internal class Program
    {
        private static void Main(string[] args)
        {
            // Invoker
            TransactionManager transactionManager = new TransactionManager();

            // Receiver
            Account myAccount = new Account("Rajiv Ranjan", 100000);
            Account hisAccount = new Account("Ribha Singh", 25000);
            PrintStatement(myAccount, hisAccount);
            // Command
            Deposit deposit = new Deposit(myAccount, 100);
            Transfer transfer = new Transfer(myAccount, hisAccount, 25000);

            // Add commans to transaction manager (invoker)
            transactionManager.AddTransaction(deposit);
            transactionManager.AddTransaction(transfer);

            // Execute commands
            transactionManager.ProcessPendingTransactions();

            Console.WriteLine("\n************** After Transaction *********************");
            PrintStatement(myAccount, hisAccount);

            Console.Read();
        }

        public static void PrintStatement(Account myAccount, Account hisAccount)
        {
            Console.WriteLine("Name : {0}, Balance: {1}", myAccount.AccountName, myAccount.Balance);
            Console.WriteLine("Name : {0}, Balance: {1}", hisAccount.AccountName, hisAccount.Balance);
        }
    }
}