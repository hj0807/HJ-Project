using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommandPattern.ex1
{
    public class Receiver
    {
        public void Action()
        {
            Debug.Log("Called Receiver.Action()");
        }
    }

    public abstract class Command 
    {
        protected Receiver receiver;

        public Command(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public abstract void Execute();
    }

    public class ConcreteCommand : Command
    {
        public ConcreteCommand(Receiver receiver) : base(receiver)
        {
        }

        public override void Execute()
        {
            receiver.Action();
        }
    }

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