using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChainOfResponsibilityPattern.ex1
{
    //c# Chain of Responsibility 구현
    //http://gorakgarak.tistory.com/465
    //http://objectbuilder.tistory.com/84

    //c# Chain of Responsibility

    public class MainProgram : MonoBehaviour
    {
        void Start()
        {
            Handler h1 = new ConcreteHandler1();
            Handler h2 = new ConcreteHandler2();
            Handler h3 = new ConcreteHandler3();

            h1.SetSuccessor(h2);
            h2.SetSuccessor(h3);

            int[] requests = { 2, 5, 14, 22, 18, 3, 27, 20 };

            for(int i=0; i<requests.Length;i++)
            {
                h1.HandlerRequest(requests[i]);
            }
        }
    }
}