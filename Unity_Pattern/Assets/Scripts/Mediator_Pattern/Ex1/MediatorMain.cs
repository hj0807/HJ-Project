using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MediatorPattern.ex1
{
    public class MediatorMain : MonoBehaviour
    {
        void Main()
        {
            IMediator mediator = new ConcreteMediator();

            ColleagueA talkColleague = new ColleagueA(mediator);
            ColleagueB fightColleague = new ColleagueB(mediator);

            talkColleague.DoSomething();
            fightColleague.DoSomething();
        }
    }
}