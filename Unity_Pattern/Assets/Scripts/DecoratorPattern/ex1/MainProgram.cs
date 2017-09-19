using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DecoratorPattern.ex1
{
    public class MainProgram : MonoBehaviour
    {
        void Start()
        {
            ConcreteComponent c = new ConcreteComponent();
            ConcreteDecoratorA dA = new ConcreteDecoratorA();
            ConcreteDecoratorB dB = new ConcreteDecoratorB();

            dA.SetComponent(c);
            dB.SetComponent(dA);
            dB.Operation();
        }
    }

}
