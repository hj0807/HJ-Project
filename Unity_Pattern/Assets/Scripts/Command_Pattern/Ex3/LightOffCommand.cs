using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommandPattern.ex3
{
    public class LightOffCommand : ICommand
    {
        private Light light;

        public LightOffCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.off();
        }

        public void Undo()
        {
            light.on();
        }
    }
}