using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MediatorPattern.ex1
{
    public abstract class Colleague
    {
        protected IMediator mediator;

        public abstract void DoSomething();
    }
}
