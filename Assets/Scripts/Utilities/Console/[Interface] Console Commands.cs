namespace inSIGHT.Scripts.Console.Commands
{

    public interface IConsoleCommand
    {
    
        string CommandWord { get; }
        bool Process(string[] args);

    }

}