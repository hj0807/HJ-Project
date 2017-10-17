using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProxyPattern.ex1
{
    public class Proxy : ISubject
    {
        private RealSubject realSubject;

        public void Request()
        {
            if (realSubject == null)
            {
                realSubject = new RealSubject();
            }

            Debug.Log("Proxy.Request()");

            realSubject.Request();
        }
    }
}