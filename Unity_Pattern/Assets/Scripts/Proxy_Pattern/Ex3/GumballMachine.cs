using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProxyPattern.ex3
{
    public class GumballMachine
    {
        private string location;

        public GumballMachine(string location, int count)
        {
            this.location = location;
        }

        public string GetLocation()
        {
            return location;
        }
    }
}