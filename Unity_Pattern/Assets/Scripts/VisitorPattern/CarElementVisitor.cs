using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//행위패턴, 방문자패턴
//http://arisu1000.tistory.com/27696

namespace VisitorPattern.ex1
{
    public interface CarElementVisitor 
    {
        void visit(Body body);
        void visit(Wheel wheel);
        void visit(Engine engine);
        void visit(Car car);
    }

    public class CarElementPrintVisitor : CarElementVisitor
    {
        public void visit(Engine engine)
        {
            Debug.Log("Visiting engine");
        }

        public void visit(Car car)
        {
            Debug.Log("Visiting car");
        }

        public void visit(Wheel wheel)
        {
            Debug.Log("Visiting " + wheel.GetName());
        }

        public void visit(Body body)
        {
            Debug.Log("Visiting body");
        }
    }

    public class CarElementDoVisitor : CarElementVisitor
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
            Debug.Log("Kicking my wheel " + wheel.GetName());
        }

        public void visit(Body body)
        {
            Debug.Log("Moving my body");
        }
    }

    public interface CarElement
    {
        void Accept(CarElementVisitor visitor); //CarElementVisitor have to provide accept().
    }

    public class Body : CarElement
    {
        public void Accept(CarElementVisitor visitor)
        {
            visitor.visit(this);
        }
    }

    public class Wheel : CarElement
    {
        private string name;

        public Wheel(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public void Accept(CarElementVisitor visitor)
        {
            visitor.visit(this);
        }
    }

    public class Engine : CarElement
    {
        public void Accept(CarElementVisitor visitor)
        {
            visitor.visit(this);
        }
    }

    public class Car : CarElement
    {
        CarElement[] elements;

        public Car()
        {
            this.elements = new CarElement[] { new Wheel("front left"),
                                               new Wheel("front right"),
                                               new Wheel("back left"),
                                               new Wheel("back right")};
        }

        public void Accept(CarElementVisitor visitor)
        {
            for(int i=0; i<elements.Length; i++)
            {
                elements[i].Accept(visitor);
            }
            visitor.visit(this);
        }
    }
}