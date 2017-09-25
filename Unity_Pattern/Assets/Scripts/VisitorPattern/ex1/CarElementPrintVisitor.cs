using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VisitorPattern.ex1
{
    public class CarElementPrintVisitor : ICarElementVisitor
    {
        public void visit(Engine engine)
        {
            Debug.Log("Visiting 엔진");
        }

        public void visit(Car car)
        {
            Debug.Log("Visiting 차");
        }

        public void visit(Wheel wheel)
        {
            Debug.Log("Visiting 바퀴" + wheel.GetName());
        }

        public void visit(Body body)
        {
            Debug.Log("Visiting 바디");
        }
    }
}
