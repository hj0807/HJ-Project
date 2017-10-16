using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatePattern.ex2
{
    public class LockDown : IUnitState
    {
        public void Attak()
        {
            Debug.Log("공격 불가능");
        }

        public void Move()
        {
            Debug.Log("이동 불가능");
        }
    }
}