using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterpreterPattern.ex3
{
    /// <summary>
    /// TerminalExpression 객체.
    /// 1 검사 = 로마숫자 I,II, III, IV, V, VI, VII,VIII, IX
    /// </summary>
    public class OneExpression : ExpressionBase
    {
        public override string One() {
            return "I";
        }

        public override string Four() {
            return "IV";
        }

        public override string Five() {
            return "V";
        }

        public override string Nine() {
            return "IX";
        }

        public override int Multiplier() {
            return 1;
        }
    }
}
