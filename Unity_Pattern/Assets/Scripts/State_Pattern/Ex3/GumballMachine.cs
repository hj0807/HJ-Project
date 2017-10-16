using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatePattern.ex3
{
    /// <summary>
    /// Context 객체.
    /// 현재 내부 상태를 가지고 있으며, 상태를 이용해 액션을 실행시킨다.
    /// </summary>
    public class GumballMachine
    {
        //미리 모든 상태 객체들을 생성해두고 삭제하지않고 사용하는 방식.
        //(상태 전환이 자주일어나는 경우에 유용)
        private IState soldOutState;
        private IState noCoinState;
        private IState hasCoinState;
        private IState soldState;

        private IState state;

        private int count = 0;

        public GumballMachine(int gumballCount)
        {
            soldOutState = new SoldOutState(this);
            noCoinState = new NoCoinState(this);
            hasCoinState = new HasCoinState(this);
            soldState = new SoldState(this);

            this.count = gumballCount;

            if(gumballCount > 0)
            {
                state = noCoinState;
            }
            else
            {
                state = soldOutState;
            }
        }

        //동전 삽입시.
        public void InsertQuarter()
        {
            state.InsertCoin();
        }

        //손잡이 돌릴때.
        public void TurnCrank()
        {
            state.TurnCrank();
            state.Dispense(); //껌볼 나올때
        }

        //동전 반환시 할일 (현재 예제에서는 사용하지않음).
        public void EjectQuarter()
        {
            state.EjectCoin();
        }

        public void ReleaseBall()
        {
            Debug.Log("껌볼이 굴러서 나온다...!");

            if(count > 0) {
                count = count - 1;
            }
        }

        public void Refill(int count)
        {
            this.count += count;
            Debug.Log("껌볼이 채워졌다. 현재 갯수 : " + this.count);
            state.Refill();
        }

        public void SetState(IState state)
        {
            this.state = state;
        }

        //Get 메서드.
        public int GetCount() { return count; }

        public IState GetState() { return state; }

        public IState GetSoldOutState() { return soldOutState; }
        public IState GetNoCoinState() { return noCoinState; }
        public IState GetHasCoinState() { return hasCoinState; }
        public IState GetSoldState() { return soldState; }
    }
}