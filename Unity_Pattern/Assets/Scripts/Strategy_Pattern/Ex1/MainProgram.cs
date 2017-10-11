using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StrategyPattern.ex1
{
    public class MainProgram : MonoBehaviour
    {
        void Start()
        {
            Context context;

            context = new Context(new ConcreteStrategyA());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyB());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyC());
            context.ContextInterface();
        }
    }
}
