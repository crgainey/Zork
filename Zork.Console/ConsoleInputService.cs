using System;

namespace Zork
{
    class ConsoleInputService : IInputService
    {
        public event EventHandler<string> InputRecieved;

        public void ProcessInput()
        {
            string inputString = Console.ReadLine().Trim().ToUpper();
            InputRecieved?.Invoke(this, inputString);
        }
    }
}
