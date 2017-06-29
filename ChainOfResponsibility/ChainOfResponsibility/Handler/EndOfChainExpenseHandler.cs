using System;

namespace ChainOfResponsibility.Handler
{
    public class EndOfChainExpenseHandler : IExpenseHandler
    {
        private EndOfChainExpenseHandler()
        {
        }

        public static EndOfChainExpenseHandler Instance
        {
            get
            {
                return Nested.instance;
            }
        }

        private class Nested
        {
            static Nested()
            {
            }

            public static EndOfChainExpenseHandler instance = new EndOfChainExpenseHandler();
        }

        public ApprovalResponse Approve(decimal expenseAmount)
        {
            return ApprovalResponse.Denied;
        }

        public void Next(IExpenseHandler next)
        {
            throw new NotImplementedException("End of chain handler must be the end of chain!");
        }
    }
}