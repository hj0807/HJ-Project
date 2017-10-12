using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverPattern.ex1
{
    /// <summary>
    /// Observer의 구체적인 구현.
    /// </summary>
    public class ConcreteObserver : Observer
    {
        private string name;
        private string observerState;

        private ConcreteSubject subject;

        public ConcreteSubject Subject
        {
            get { return subject; }
            set { subject = value; }
        }

        public ConcreteObserver(string name, ConcreteSubject subject)
        {
            this.name = name;
            this.subject = subject;
        }

        public override void Update()
        {
            observerState = subject.SubjectState;
            Debug.Log(string.Format("Observer {0}'s new state is {1}", name, observerState));
        }
    }
}
