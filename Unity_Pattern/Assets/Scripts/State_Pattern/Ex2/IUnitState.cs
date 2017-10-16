using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatePattern.ex2
{
    public interface IUnitState
    {
        void Attak();
        void Move();
    }
}