using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverPattern.ex1
{
    /// <summary>
    /// 관찰자 역할
    /// Subject로부터 상태 변화를 통보받는 역할.
    /// </summary>
    public abstract class Observer
    {
        public abstract void Update();
    }
}