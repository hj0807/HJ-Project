using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VisitorPattern.ex1
{
    public class MainProgram : MonoBehaviour
    {
        void Start()
        {
            CarElement car = new Car();

            car.Accept(new CarElementPrintVisitor());
            car.Accept(new CarElementDoVisitor());
        }
    }
}