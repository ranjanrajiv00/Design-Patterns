using CommandPattern.Command;
using System.Collections.Generic;
using System.Linq;

namespace CommandPattern
{
    /// <summary>
    /// Command Invoker
    /// </summary>
    public class CommandParser
    {
        private readonly IEnumerable<ICommandFactory> _availableCommans;

        public CommandParser(IEnumerable<ICommandFactory> availableCommans)
        {
            _availableCommans = availableCommans;
        }

        public ICommand ParseCommands(string[] args)
        {
            var reqestedCommandName = args[0];
            var command = GetRequestedCommand(reqestedCommandName);
            return command.MakeCommand(args);
        }

        private ICommandFactory GetRequestedCommand(string reqestedCommandName)
        {
            return _availableCommans.FirstOrDefault(cmd => cmd.CommandName == reqestedCommandName);
        }
    }
}