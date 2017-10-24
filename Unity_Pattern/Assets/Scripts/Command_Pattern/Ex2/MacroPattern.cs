using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommandPatter.ex2
{
    public class MacroPattern
    {
        private List<ICommand> commandList;

        public MacroPattern()
        {
            commandList = new List<ICommand>();
        }

        public void Add(ICommand command)
        {
            commandList.Add(command);
        }

        public void Run()
        {
            for (int i = 0; i < commandList.Count; i++)
            {
                commandList[i].Execute();
            }
        }
    }
}