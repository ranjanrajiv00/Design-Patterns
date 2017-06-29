using System;

namespace Problem
{
    public class Employee
    {
        public string Name { get; }
        private readonly Decimal approvalLimit;

        public Employee(string _name, Decimal _approvalLimit)
        {
            this.Name = _name;
            this.approvalLimit = _approvalLimit;
        }

        public ApprovalResponse ApproveExpense(Decimal expenseAmount)
        {
            return expenseAmount > approvalLimit ? ApprovalResponse.BeyondApprovalLimit : ApprovalResponse.Approved;
        }
    }
}