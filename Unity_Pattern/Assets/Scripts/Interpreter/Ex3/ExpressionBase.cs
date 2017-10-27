using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterpreterPattern.ex3
{
    public abstract class ExpressionBase
    {
        public void Interpret(Context context)
        {
            if (context.Input.Length == 0)
                return;

            if (context.Input.StartsWith(Nine()))
            {
                context.Output += (9 * Multiplier());
                context.Input = context.Input.Substring(2);
                Debug.Log("[9] " + context.Input);
            }
            else if(context.Input.StartsWith(Four()))
            {
                context.Output += (4 * Multiplier());
                context.Input = context.Input.Substring(2);
                Debug.Log("[4] " + context.Input);
            }
            else if (context.Input.StartsWith(Five()))
            {
                context.Output += (5 * Multiplier());
                context.Input = context.Input.Substring(1);
                Debug.Log("[5] " + context.Input);
            }

            while(context.Input.StartsWith(One()))
            {
                context.Output += (1 * Multiplier());
                context.Input = context.Input.Substring(1);
                Debug.Log("[1] " + context.Input + ", " + context.Output);
            }
        }

        public abstract string One();
        public abstract string Four();
        public abstract string Five();
        public abstract string Nine();

        public abstract int Multiplier();
    }
}