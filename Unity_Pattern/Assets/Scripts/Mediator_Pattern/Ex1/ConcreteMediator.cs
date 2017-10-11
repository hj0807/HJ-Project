using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MediatorPattern.ex1
{
    public class ConcreteMediator : IMediator
    {
        private ColleagueA talk;
        private ColleagueB fight;

        public void Fight()
        {
            Debug.Log("Mediator is fighting");
        }

        public void Talk()
        {
            Debug.Log("Mediator is talking");
        }

        public void RegisterA(ColleagueA cA)
        {
            talk = cA;
        }

        public void RegisterB(ColleagueB cB)
        {
            fight = cB;
        }
    }
}