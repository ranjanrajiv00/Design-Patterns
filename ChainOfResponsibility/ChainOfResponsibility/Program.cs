using ChainOfResponsibility.Handler;
using System;

namespace ChainOfResponsibility
{
    /// <summary>
    /// Approve bill amount
    /// The Chain of Responsibility Pattern describes how we handle a single request by a chain of multiple handler.
    /// Sender is aware of only one receiver.
    /// Each receiver is only aware of next receiver.
    /// Receivers process the message and terminate the chain or sent it down the chain.
    /// The sender does not know who received the message
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            IExpenseHandler rajiv = new ExpenseHandler(new Employee("Rajiv", Decimal.Zero));
            IExpenseHandler arunChaudhary = new ExpenseHandler(new Employee("Arun", new Decimal(1000)));
            IExpenseHandler sanjeevDhawan = new ExpenseHandler(new Employee("Sanjeev", new Decimal(5000)));
            IExpenseHandler aviragJain = new ExpenseHandler(new Employee("Avirag", new Decimal(20000)));

            rajiv.Next(arunChaudhary);
            arunChaudhary.Next(sanjeevDhawan);
            sanjeevDhawan.Next(aviragJain);

            Decimal expenseReportAmount = 5845000;
            ApprovalResponse response = rajiv.Approve(expenseReportAmount);

            Console.WriteLine("The request was {0}", response);

            Console.Read();
        }
    }
}