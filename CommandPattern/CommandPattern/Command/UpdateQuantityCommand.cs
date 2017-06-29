using System;

namespace CommandPattern.Command
{
    public class UpdateQuantityCommand : ICommand, ICommandFactory
    {
        public string CommandName { get { return "UpdateQuantity"; } }

        public string Description { get { return "UpdateQuantity number"; } }

        public int NewQuantity { get; set; }

        public void Execute()
        {
            const int oldQuantity = 5;
            Console.WriteLine("Quantity has been changed from {0} to {1}", oldQuantity, NewQuantity);
        }

        public ICommand MakeCommand(string[] args)
        {
            return new UpdateQuantityCommand()
            {
                NewQuantity = int.Parse(args[1])
            };
        }
    }
}