using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MediatorPattern.ex1
{
    public interface IMediator 
    {
        void Fight();
        void Talk();
        void RegisterA(ColleagueA cA);
        void RegisterB(ColleagueB cB);
    }
}