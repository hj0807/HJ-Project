using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatePattern.ex3
{
    /// <summary>
    /// Concrete State
    /// 동전이 없는 상태를 나타내는 객체.
    /// </summary>
    public class NoCoinState : IState
    {
        private GumballMachine gumballMachine;

        /// <summary>
        /// 생성자를 통해서 뽑기기계 객체를 전달.
        /// </summary>
        /// <param name="gumballMachine"></param>
        public NoCoinState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        /// <summary>
        /// 현재 돈이 없는 상태이므로, 돈을 넣어주면 정상 투입 메시지를 출력하고
        /// 뽑기기계 상태를 NoCoin에서 -> HasCoin상태로 변경한다.
        /// </summary>
        public void InsertCoin()
        {
            Debug.Log("동전 투입하였다.");

            gumballMachine.SetState(gumballMachine.GetHasCoinState());
        }
        
        public void EjectCoin()
        {
            Debug.Log("동전을 넣지않아서 돌려줄게 없다.");
        }

        public void TurnCrank()
        {
            Debug.Log("손잡이를 돌렸지만, 동전이 없다.");
        }

        public void Dispense()
        {
            Debug.Log("동전이 없으니 먼저, 동전을 넣어라.");
        }

        public void Refill() { }

        public string ToString() {
            return "동전 기다리는중...";
        }
    }
}