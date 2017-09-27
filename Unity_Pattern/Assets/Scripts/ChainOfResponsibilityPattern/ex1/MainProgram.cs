using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChainOfResponsibilityPattern.ex1
{
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