using CommandPattern.Core.Contracts;
using System;
using System.Linq;
using System.Reflection;

namespace CommandPattern.Core.Models
{
    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            string[] inputTokens = args
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string commandType = inputTokens[0];
            string[] commandArguments = inputTokens.Skip(1).ToArray();

            string result = string.Empty;
           // ICommand command = null;

            var type = Assembly.GetCallingAssembly().GetTypes()
                .FirstOrDefault(c => c.Name.StartsWith(commandType));

            var instance = (ICommand)Activator.CreateInstance(type);


            //if (commandType == "HelloCommand")
            //{
            //    command = new HelloCommand();
            //}
            //else if (commandType == "ExitCommand")
            //{
            //    command = new ExitCommand();
            //}
            result = instance.Execute(commandArguments);
            return result;

        }
    }
}
