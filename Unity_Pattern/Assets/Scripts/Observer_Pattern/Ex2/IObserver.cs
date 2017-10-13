using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverPattern.ex2
{
    //옵저버 인터페이스.
    public interface IObserver
    {
        void Update(float temp, float humidity, float pressure);
    }
}
