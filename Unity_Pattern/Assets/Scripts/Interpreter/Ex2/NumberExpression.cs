using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterpreterPattern.ex2
{
    public class NumberExpression : IExpression
    {
        private int number;

        public NumberExpression(int number)
        {
            this.number = number;
        }

        //override.
        public int Interpret()
        {
            return number;
        }
    }
}
