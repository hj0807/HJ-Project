using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MediatorPattern.ex1
{
    public class ColleagueA : Colleague
    {
        public ColleagueA(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public override void DoSomething()
        {
            mediator.Talk();
            mediator.RegisterA(this);
        }
    }

    public class ColleagueB : Colleague
    {
        public ColleagueB(IMediator mediator)
        {
            this.mediator = mediator;
            mediator.RegisterB(this);
        }

        public override void DoSomething()
        {
            mediator.Fight();
        }
    }
}
