using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Execut0r
{
    public class Executor
    {
        public Executor()
        {
        }

        public Executor(string path, List<Option> options, List<Argument> arguments)
        {
            Path = path;
            Options = options;
            Arguments = arguments;
        }

        public string Path;
        public List<Option> Options { get; set; }
        public List<Argument> Arguments { get; set; }

        public void Execute()
        {
            var command = new StringBuilder();

            foreach (var option in Options) //Options
            {
                command.Append(" ");
                command.Append(option.Name);
            }

            foreach (var argument in Arguments) //Arguments
            {
                command.Append(" ");
                command.Append(argument.Name);
                command.Append(" ");
                command.Append(argument.Parameter);
            }

            Process.Start(Path, command.ToString());
        }
    }
}