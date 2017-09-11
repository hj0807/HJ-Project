using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace BridgePatter.ex1
{
    public class MainProgram : MonoBehaviour
    {
        void Start()
        {
            Abstraction ab = new Abstraction();

            ab.Implementor = new ConcreteImplementorA();
            ab.Operation();

            ab.Implementor = new ConcreteImplementorB();
            ab.Operation();
        }
    }
}