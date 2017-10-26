using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterpreterPattern.ex1
{
    public class MainProgram : MonoBehaviour
    {
        void Main()
        {
            Context context = new Context();

            List<IExpression> expressionList = new List<IExpression>();

            expressionList.Add(new TerminalExpression());
            expressionList.Add(new NonTerminalExpression());
            expressionList.Add(new TerminalExpression());
            expressionList.Add(new TerminalExpression());

            for(int i=0; i<expressionList.Count; i++)
            {
                expressionList[i].Interpret(context);
            }
        }
    }
}