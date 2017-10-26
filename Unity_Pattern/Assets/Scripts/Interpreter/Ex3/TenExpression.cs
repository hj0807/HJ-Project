using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterpreterPattern.ex3
{
    /// <summary>
    /// TerminalExpression 객체.
    /// 10 검사 = 로마숫자 X, XL, L, XC
    /// </summary>
    public class TenExpression : ExpressionBase
    {
        public override string One() {
            return "X";
        }

        public override string Four() {
            return "XL";
        }

        public override string Five() {
            return "L";
        }

        public override string Nine() {
            return "XC";
        }

        public override int Multiplier() {
            return 10;
        }
    }
}
