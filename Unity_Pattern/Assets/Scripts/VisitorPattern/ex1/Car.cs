using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace VisitorPattern.ex1
{
    public class Car : ICarElement
    {
        ICarElement[] elements;

        public Car()
        {
            this.elements = new ICarElement[] { new Wheel("front left"),
                                               new Wheel("front right"),
                                               new Wheel("back left"),
                                               new Wheel("back right")};
        }

        public void Accept(ICarElementVisitor visitor)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                elements[i].Accept(visitor);
            }
            visitor.visit(this);
        }
    }
}