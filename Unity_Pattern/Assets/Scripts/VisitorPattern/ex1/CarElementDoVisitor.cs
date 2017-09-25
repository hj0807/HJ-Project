using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VisitorPattern.ex1
{
    public class CarElementDoVisitor : ICarElementVisitor
    {
        public void visit(Engine engine)
        {
            Debug.Log("Starting my engine");
        }

        public void visit(Car car)
        {
            Debug.Log("Starting my car");
        }

        public void visit(Wheel wheel)
        {
            Debug.Log("Kicking my 바퀴 " + wheel.GetName());
        }

        public void visit(Body body)
        {
            Debug.Log("Moving my body");
        }
    }
}