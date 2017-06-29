using System;

namespace ExpenseApprovalSystem.Approver
{
    public class ReportingManger : IApprover
    {
        private const Decimal MAX_APPROVAL_LIMIT = 20000;
        public string Name { get; set; }
        public IApprover Next { get; set; }

        public ApprovalResponse Approve(decimal expenseAmount)
        {
            if (expenseAmount <= MAX_APPROVAL_LIMIT)
            {
                return ApprovalResponse.Approved;
            }
            else if (Next != null)
            {
                return Next.Approve(expenseAmount);
            }
            return ApprovalResponse.Denied;
        }
    }
}