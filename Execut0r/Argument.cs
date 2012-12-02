namespace Execut0r
{
    public class Argument
    {
        public Argument()
        {
        }

        public Argument(string name, string parameter)
        {
            Name = name;
            Parameter = parameter;
        }

        public string Name { get; set; }

        public string Parameter { get; set; }
    }
}