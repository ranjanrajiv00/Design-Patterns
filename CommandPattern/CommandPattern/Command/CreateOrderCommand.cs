using System;

namespace CommandPattern.Command
{
    public class CreateOrderCommand : ICommand, ICommandFactory
    {
        public string CommandName
        {
            get
            {
                return "CreateOrder";
            }
        }

        public string Description
        {
            get
            {
                return "CreateOrder";
            }
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }

        public ICommand MakeCommand(string[] args)
        {
            throw new NotImplementedException();
        }
    }
}