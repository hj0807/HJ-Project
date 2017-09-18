using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StrategyPattern.ex1
{
    public abstract class Strategy
    {
        public abstract void AlgorithmInterface();
    }

    public class ConcreteStrategyA : Strategy
    {
        public override void AlgorithmInterface()
        {
            Debug.Log("ConcreteStrategyA.AlgorithmInterface()");
        }
    }

    public class ConcreteStrategyB : Strategy
    {
        public override void AlgorithmInterface()
        {
            Debug.Log("ConcreteStrategyB.AlgorithmInterface()");
        }
    }

    public class ConcreteStrategyC : Strategy
    {
        public override void AlgorithmInterface()
        {
            Debug.Log("ConcreteStrategyC.AlgorithmInterface()");
        }
    }
}
