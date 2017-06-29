namespace ChainOfResponsibility.Handler
{
    public class ExpenseHandler : IExpenseHandler
    {
        private readonly Employee _approver;
        private IExpenseHandler _next;

        public ExpenseHandler(Employee expenseApprover)
        {
            _approver = expenseApprover;
            _next = EndOfChainExpenseHandler.Instance;
        }

        public ApprovalResponse Approve(decimal expenseAmount)
        {
            ApprovalResponse response = _approver.Approve(expenseAmount);
            if (response == ApprovalResponse.BeyondApprovalLimit)
            {
                return _next.Approve(expenseAmount);
            }
            return response;
        }

        public void Next(IExpenseHandler next)
        {
            _next = next;
        }
    }
}