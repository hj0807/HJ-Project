using UnityEngine;

namespace BridgePatter.ex1
{
    public abstract class Implementor {

        public abstract void Operation();
    }

    public class ConcreteImplementorA : Implementor
    {
        public override void Operation()
        {
            Debug.Log("ConcreteImplementor A Operation");
        }
    }

    public class ConcreteImplementorB : Implementor
    {
        public override void Operation()
        {
            Debug.Log("ConcreteImplementor B Operation");
        }
    }
}
