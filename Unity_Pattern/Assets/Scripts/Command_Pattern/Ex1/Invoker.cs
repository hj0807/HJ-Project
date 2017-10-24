using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommandPattern.ex1
{
    public class Invoker
    {
        private Command command;

        public void SetCommand(Command command)
        {
            this.command = command;
        }

        public void ExecuteCommand()
        {
            command.Execute();
        }
    }
}
