using UnityEngine;

namespace inSIGHT.Scripts.Console.Commands
{

    public abstract class ConsoleCommand : ScriptableObject, IConsoleCommand
    {
        [SerializeField] private string commandWord = string.Empty;

        public string CommandWord => commandWord; // throw new System.NotImplementedException();
        public abstract bool Process(string[] args);

    }

}