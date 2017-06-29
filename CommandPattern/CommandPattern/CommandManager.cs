using CommandPattern.Command;
using System;
using System.Collections.Generic;

namespace CommandPattern
{
    public class CommandManager
    {
        public static void Run(string[] args)
        {
            // Get available commands
            // Take command from user
            // Use factory to get instance of current command
            // Execute command

            // Get available commans
            var availableCommands = GetAvailableCommands();

            // Take command from user
            if (args.Length == 0)
            {
                Console.Write("Commans:\n");
                foreach (var item in availableCommands)
                {
                    Console.Write("\t{0}\n", item.CommandName);
                }
                return;
            }

            // Use factory to get instance of current command
            var parser = new CommandParser(availableCommands);
            var command = parser.ParseCommands(args);

            // Execute command
            if (command != null)
                command.Execute();
        }

        private static IEnumerable<ICommandFactory> GetAvailableCommands()
        {
            return new ICommandFactory[] {
                new UpdateQuantityCommand(),
                new CreateOrderCommand(),
                new ShipOrderCommand()
            };
        }
    }
}