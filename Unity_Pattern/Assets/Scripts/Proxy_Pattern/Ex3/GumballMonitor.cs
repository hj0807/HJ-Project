using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProxyPattern.ex3
{
    public class GumballMonitor {

        private GumballMachine machine;

        public GumballMonitor(GumballMachine machine)
        {
            this.machine = machine;
        }

        public void Report()
        {

        }
    }
}