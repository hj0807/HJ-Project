using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MementoPattern.ex1
{
    public class Originator
    {
        private string state;

        public void SetState(string state)
        {
            this.state = state;
        }

        public string GetState()
        {
            return state;
        }

        public Memento SaveStateToMemento()
        {
            return new Memento(state);
        }

        public void GetStateFromMemento(Memento memento)
        {
            state = memento.GetState();
        }
    }
}
