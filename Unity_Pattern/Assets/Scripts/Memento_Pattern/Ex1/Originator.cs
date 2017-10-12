using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MementoPattern.ex1
{
    public class Originator
    {
        private string state;

        //Originator 객체의 상태를 설정.
        public void SetState(string state) {
            this.state = state;
        }

        public string GetState() {
            return state;
        }

        public Memento SaveStateToMemento() {
            return new Memento(state);
        }

        public void GetStateFromMemento(Memento memento) {
            state = memento.GetState();
        }
    }
}
