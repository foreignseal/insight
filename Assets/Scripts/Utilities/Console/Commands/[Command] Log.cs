using UnityEngine;

namespace inSIGHT.Scripts.Console.Commands
{
    [CreateAssetMenu(fileName = "New Log Command", menuName = "Utilities/Console/Commands/Log Command")]
    public class LogCommand : ConsoleCommand
    {
        public override bool Process(string[] args)
        {
            string logText = string.Join(" ", args);

            Debug.Log(logText);

            return true;
        }
    }
}