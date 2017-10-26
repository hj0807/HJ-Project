using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterpreterPattern.ex3
{
    /// <summary>
    /// TerminalExpression 객체.
    /// 100 검사 = 로마숫자 C,CD,D,CM
    /// </summary>
    public class HundredExpression : ExpressionBase
    {
        public override string One() {
            return "C";
        }

        public override string Four() {
            return "CD";
        }

        public override string Five() {
            return "D";
        }

        public override string Nine() {
            return "CM";
        }

        public override int Multiplier() {
            return 100;
        }
    }
}