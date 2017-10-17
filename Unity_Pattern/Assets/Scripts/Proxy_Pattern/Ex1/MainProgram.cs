using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProxyPattern.ex1
{
    public class MainProgram : MonoBehaviour {

        void Main()
        {
            Proxy proxy = new Proxy();
            proxy.Request();
        }
    }
}