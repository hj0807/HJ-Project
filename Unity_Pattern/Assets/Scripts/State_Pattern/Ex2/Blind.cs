using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatePattern.ex2
{
    public class Blind : IUnitState
    {
        public void Attak()
        {
            Debug.Log("공격 가능");
        }

        public void Move()
        {
            Debug.Log("이동 가능 시야 1");
        }
    }
}