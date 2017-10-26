using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterpreterPattern.ex2
{
    public class AddExpression : IExpression
    {
        private IExpression leftExpression;
        private IExpression rightExpression;

        public AddExpression(IExpression left, IExpression right)
        {
            leftExpression = left;
            rightExpression = right;
        }

        public int Interpret()
        {
            int result = leftExpression.Interpret() + rightExpression.Interpret();
            return result;
        }
    }
}