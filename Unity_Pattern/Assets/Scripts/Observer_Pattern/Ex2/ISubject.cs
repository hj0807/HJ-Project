using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverPattern.ex2
{
    // 주제 인터페이스.
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();
    }
}