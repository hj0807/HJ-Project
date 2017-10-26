using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterpreterPattern.ex1
{
    /// <summary>
    /// 문법적으로 터미널 토큰 요소를 포함하지 않는 모든 종류의 문장을 번역한다.
    /// </summary>
    public class NonTerminalExpression : IExpression
    {
        public void Interpret(Context context)
        {
            Debug.Log("Called NonTerminal.Interpret()");
        }
    }
}
