using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatePattern.ex2
{
    public class SiegeTank : MonoBehaviour
    {
        private IUnitState unitState;

        public SiegeTank(IUnitState unitState)
        {
            this.unitState = unitState;
        }

        public void Attacked(string attack)
        {
            switch(attack)
            {
                case "Medic Blind":
                    Debug.Log("메딕에게 블라인드 상태이상 공격을 받음");
                    unitState = new Blind();
                    break;
                case "Ghost LockDown":
                    Debug.Log("고스트에게 락다운 상태이상 공격을 받음");
                    unitState = new LockDown();
                    break;
                default:
                    break;
            }
        }

        public void Attack()
        {
            unitState.Attak();
        }

        public void Move()
        {
            unitState.Move();
        }
    }
}