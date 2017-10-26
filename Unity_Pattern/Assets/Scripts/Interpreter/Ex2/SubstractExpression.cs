using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterpreterPattern.ex2
{
    public class SubstractExpression : IExpression
    {
        private IExpression leftExpression;
        private IExpression rightExpression;

        public SubstractExpression(IExpression left, IExpression right)
        {
            leftExpression = left;
            rightExpression = right;
        }

        public int Interpret()
        {
            int result = leftExpression.Interpret() - rightExpression.Interpret();
            return result;
        }
    }
}
