using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatePattern.ex3
{
    /// <summary>
    /// State 역할.
    /// 상태를 나타내는 객체들이 구현할 interface.
    /// </summary>
    public interface IState
    {
        void InsertCoin(); //동전 투입.

        void EjectCoin(); //동전 반환.

        void TurnCrank(); //손잡이 돌림.

        void Dispense(); //뽑기물 내보냄.

        void Refill(); //뽑기 채워넣음.
    }
}