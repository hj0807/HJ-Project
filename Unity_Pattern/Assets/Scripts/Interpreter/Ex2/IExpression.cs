using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//https://www.codeproject.com/Articles/186183/Interpreter-Design-Pattern

namespace InterpreterPattern.ex2
{
    public interface IExpression
    {
        int Interpret();
    }
}