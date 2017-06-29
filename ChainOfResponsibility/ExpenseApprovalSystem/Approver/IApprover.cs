using System;

namespace ExpenseApprovalSystem.Approver
{
    public interface IApprover
    {
        string Name { get; set; }

        ApprovalResponse Approve(Decimal expenseAmount);

        IApprover Next { get; set; }
    }
}