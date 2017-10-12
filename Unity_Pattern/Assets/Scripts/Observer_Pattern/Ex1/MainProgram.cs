using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverPattern.ex1
{
    public class MainProgram : MonoBehaviour
    {
        //옵저버 패턴 ConcreteObserver 역할
        void Main()
        {
            ConcreteSubject subject = new ConcreteSubject();
            
            subject.Attach(new ConcreteObserver("해리포터", subject));
            subject.Attach(new ConcreteObserver("론", subject));
            subject.Attach(new ConcreteObserver("말포이", subject));

            subject.SubjectState = "ABC";
            subject.Notify();
        }
    }
}
