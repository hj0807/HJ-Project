using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterpreterPattern.ex3
{
    //http://www.dofactory.com/net/interpreter-design-pattern

    public class MainProgram : MonoBehaviour
    {
        /// <summary>
        /// 로마 숫자를 10진수로 변환하는데 사용되는 인터프리터 패턴을 보여준다.
        /// </summary>
        void Main()
        {
            string roman = "MCMXXVIII";
            Context context = new Context(roman);

            List<ExpressionBase> tree = new List<ExpressionBase>();
            tree.Add(new ThousandExpression());
            tree.Add(new HundredExpression());
            tree.Add(new TenExpression());
            tree.Add(new OneExpression());

            //해석하는 부분.
            //for(int i=0; i<tree.Count; i++)
            for (int i = 0; i < 1; i++)
            {
                tree[i].Interpret(context);
            }

            Debug.Log(string.Format("{0} = {1}", roman, context.Output));
        }
    }
}
