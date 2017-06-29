using System;
using System.Collections.Generic;

namespace Problem
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
            List<Employee> managers = new List<Employee>() {
                new Employee("Rajiv Ranjan", Decimal.Zero),
                new Employee("Arun Chaudhary", new Decimal(1000)),
                new Employee("Sanjeev Dhawan", new Decimal(5000)),
                new Employee("Avirag Jain", new Decimal(20000))
            };

            Decimal expenseReportAmount = 500;
            bool expenseProcessed = false;

            // Problem : Requester has to go to each manager for approval.
            // Requestor should only go to manager for approval.
            // If manager is not able to approve then its manager's responsibility to forward request to next lever for approval
            foreach (Employee approver in managers)
            {
                ApprovalResponse response = approver.ApproveExpense(expenseReportAmount);
                if (response != ApprovalResponse.BeyondApprovalLimit)
                {
                    Console.WriteLine("The request was {0}", response);
                    expenseProcessed = true;
                    break;
                }
            }

            if (!expenseProcessed)
            {
                Console.WriteLine("No one was able to approve your expense.");
            }

            Console.Read();
        }
    }
}