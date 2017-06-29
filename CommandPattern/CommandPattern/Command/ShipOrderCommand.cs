using System;

namespace CommandPattern.Command
{
    public class ShipOrderCommand : ICommand, ICommandFactory
    {
        public string CommandName
        {
            get
            {
                return "ShipCommand";
            }
        }

        public string Description
        {
            get
            {
                return "ShipCommand";
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