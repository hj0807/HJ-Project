using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterpreterPattern.ex3
{
    /// <summary>
    /// TerminalExpression 객체.
    /// 1000 검사 = 로마숫자 M
    /// </summary>
    public class ThousandExpression : ExpressionBase {

        public override string One() {
            return "M";
        }

        public override string Four() {
            return " ";
        }

        public override string Five() {
            return " ";
        }

        public override string Nine() {
            return " ";
        }

        public override int Multiplier() {
            return 1000;
        }
    }
}
