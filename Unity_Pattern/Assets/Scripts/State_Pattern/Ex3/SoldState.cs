using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatePattern.ex3
{
    /// <summary>
    /// Concrete State
    /// 뽑기가 정상적으로 나온 상태를 나타내는 객체.
    /// </summary>
    public class SoldState : IState
    {
        private GumballMachine gumballMachine;

        public SoldState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void InsertCoin()
        {
            Debug.Log("기다려요. 껌볼이 나오는 중입니다.");
        }

        public void EjectCoin()
        {
            Debug.Log("쏘리, 너는 이미 뽑기를 돌렸어");
        }

        public void TurnCrank()
        {
            Debug.Log("2번돌려도 껌 2개 안줘");
        }

        /// <summary>
        /// 뽑기기계가 정상작동한 상태이므로, 껌볼을 준다.
        /// 껌볼이 남았으면 Sold->NoCoin으로 / 매진됐으면 Sold->SoldOut상태로 변경한다.
        /// </summary>
        public void Dispense()
        {
            gumballMachine.ReleaseBall(); //껌볼나온다.

            if(gumballMachine.GetCount() > 0)
            {
                gumballMachine.SetState(gumballMachine.GetNoCoinState());
            }
            else
            {
                Debug.Log("웁스, 껌볼이 없다.");
                gumballMachine.SetState(gumballMachine.GetSoldOutState());
            }
        }

        public void Refill()
        {
        }

        public string ToString()
        {
            return "dispensing a gumball";
        }
    }
}