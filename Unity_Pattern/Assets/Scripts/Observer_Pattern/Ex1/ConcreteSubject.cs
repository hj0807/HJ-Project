using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverPattern.ex1
{
    public class ConcreteSubject : Subject
    {
        private string subjectState;

        public string SubjectState
        {
            get
            {
                return subjectState;
            }
            set
            {
                subjectState = value;
            }
        }
    }
}