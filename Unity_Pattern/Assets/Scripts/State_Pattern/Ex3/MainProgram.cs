using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatePattern.ex3
{
    public class MainProgram : MonoBehaviour
    {
        void Main()
        {
            GumballMachine gumballMachine = new GumballMachine(2);

            Debug.Log("=================");

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Debug.Log("=================");

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Debug.Log("=================");

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Debug.Log("=================");

            gumballMachine.Refill(5);
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
        }
    }
}