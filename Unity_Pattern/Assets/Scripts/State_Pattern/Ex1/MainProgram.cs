using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatePattern.ex1
{
    public class MainProgram : MonoBehaviour
    {
        void Main()
        {
            Context context = new Context(new ConcreteStateA());

            context.Request();
            context.Request();
            context.Request();
            context.Request();
        }
    }
}