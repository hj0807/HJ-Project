using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommandPattern.ex1
{
    //참고 (Head First)
    //http://secretroute.tistory.com/entry/Head-First-Design-Pattern-%EC%A0%9C6%EA%B0%95-Command-%ED%8C%A8%ED%84%B4
    //http://moonshoo.tistory.com/5

    public class MainProgram : MonoBehaviour
    {
        void Main()
        {
            Receiver receiver = new Receiver();
            Command command = new ConcreteCommand(receiver);

            Invoker invoker = new Invoker(command);

            invoker.ExecuteCommand();
        }
    }
}
