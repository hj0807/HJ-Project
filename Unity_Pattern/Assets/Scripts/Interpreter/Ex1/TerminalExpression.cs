using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterpreterPattern.ex1
{
    /// <summary>
    /// 문법적으로 터미널 토큰 요소를 포함하는 모든 종류의 식을 번역한다.
    /// </summary>
    public class TerminalExpression : IExpression
    {
        public void Interpret(Context context)
        {
            Debug.Log("Called Terminal.Interpret()");
        }
    }
}
