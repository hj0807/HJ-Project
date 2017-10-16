using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatePattern.ex1
{
    public interface IState {
        void Handle(Context context);
    }

    public class ConcreteStateA : IState
    {
        public void Handle(Context context)
        {
            context.State = new ConcreteStateB();
        }
    }

    public class ConcreteStateB : IState
    {
        public void Handle(Context context)
        {
            context.State = new ConcreteStateA();
        }
    }

    public class Context
    {
        private IState state;

        public Context(IState state)
        {
            this.state = state;
        }

        public void Request()
        {
            state.Handle(this);
        }

        public IState State
        {
            set
            {
                state = value;
                Debug.Log("State : " + state.GetType().Name);
            }

            get
            {
                return state;
            }
        }
    }
}