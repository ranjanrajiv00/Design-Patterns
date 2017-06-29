using System;

namespace ChainOfResponsibility.Handler
{
    public interface IExpenseHandler
    {
        ApprovalResponse Approve(Decimal expenseAmount);

        void Next(IExpenseHandler next);
    }
}