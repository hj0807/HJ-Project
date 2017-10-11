using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MementoPattern.ex1
{
    public class Memento
    {
        private string state;

        public Memento(string state)
        {
            this.state = state;
        }

        public string GetState()
        {
            return state;
        }
    }
}