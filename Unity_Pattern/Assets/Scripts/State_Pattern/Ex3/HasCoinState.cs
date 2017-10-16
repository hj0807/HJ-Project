using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatePattern.ex3
{
    /// <summary>
    /// Concrete State
    /// 동전이 투입된 상태를 나타내는 객체.
    /// </summary>
    public class HasCoinState : IState
    {
        private GumballMachine gumballMachine;

        public HasCoinState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void InsertCoin()
        {
            Debug.Log("동전을 또 넣을 수 없다.");
        }

        public void EjectCoin()
        {
            Debug.Log("동전 반환했다.");
        }

        /// <summary>
        /// 현재 돈이 투입된 상태이므로, 뽑기 손잡이를 돌리면 정상 메시지를 출력하고
        /// 뽑기기계 상태를 HasCoin -> Sold 상태로 변경한다.
        /// </summary>
        public void TurnCrank()
        {
            Debug.Log("뽑기 돌렸다.");
            gumballMachine.SetState(gumballMachine.GetSoldState());
        }

        public void Dispense()
        {
            Debug.Log("껌볼 주지마라.");
        }

        public void Refill()
        {
        }

        public String ToString()
        {
            return "뽑기 돌리기를 기다림...";
        }
    }
}