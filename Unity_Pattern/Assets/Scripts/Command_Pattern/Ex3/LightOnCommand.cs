using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommandPattern.ex3
{
    public class LightOnCommand : ICommand
    {
        private Light light;

        public LightOnCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.on();
        }

        public void Undo()
        {
            light.off();
        }
    }
}