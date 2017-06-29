using ExpenseApprovalSystem.Approver;
using System;

namespace ExpenseApprovalSystem
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IApprover rajiv = new TeamLeader();
            IApprover arunChaudhary = new ProjectManager();
            IApprover sanjeevDhawan = new ReportingManger();
            IApprover aviragJain = new AVP();

            rajiv.Next = arunChaudhary;
            arunChaudhary.Next = sanjeevDhawan;
            sanjeevDhawan.Next = aviragJain;

            Decimal expenseReportAmount = 50000;
            ApprovalResponse response = rajiv.Approve(expenseReportAmount);

            Console.WriteLine("The request was {0}", response);

            Console.Read();
        }
    }
}