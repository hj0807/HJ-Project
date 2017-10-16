using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatePattern.ex3
{
    /// <summary>
    /// Concrete State
    /// 뽑기가 매진된 상태를 나타내는 객체.
    /// </summary>
    public class SoldOutState : IState
    {
        private GumballMachine gumballMachine;

        public SoldOutState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void InsertCoin()
        {
            Debug.Log("동전을 넣을 수 없음. 기계가 매진됨.");
        }

        public void EjectCoin()
        {
            Debug.Log("동전 반환 안됨. 동전을 넣지않았음.");
        }

        public void TurnCrank()
        {
            Debug.Log("손잡이를 돌려도, 껌볼은 없다.");
        }

        public void Dispense()
        {
            Debug.Log("껌볼없으니 제공하지마라.");
        }

        /// <summary>
        /// 뽑기기계가 매진된 상태이므로, 해당 메소드 호출하면
        /// 뽑기를 다시 채워넣고, 기계 상태를 SoldOut->NoCoin 상태로 변경한다.
        /// </summary>
        public void Refill()
        {
            gumballMachine.SetState(gumballMachine.GetNoCoinState());
        }

        public string ToString()
        {
            return "매진!!!";
        }
    }
}