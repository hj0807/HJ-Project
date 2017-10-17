using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProxyPattern.ex1
{
    public class RealSubject : ISubject
    {
        public void Request()
        {
            Debug.Log("RealSubject.Request()");
        }
    }
}