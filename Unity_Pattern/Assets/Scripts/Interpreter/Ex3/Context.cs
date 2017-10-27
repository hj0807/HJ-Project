using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterpreterPattern.ex3
{
    /// <summary>
    /// Context 객체.
    /// 인터프리터가 구문해석을 실행하기 위한 정보를 제공.
    /// </summary>
    public class Context
    {
        private string input;
        private int output;

        public Context(string input)
        {
            Input = input;
        }

        //get, set method.
        public string Input
        {
            get
            {
                return input;
            }
            set
            {
                input = value;
            }
        }

        public int Output
        {
            get
            {
                return output;
            }
            set
            {
                output = value;
            }
        }
    }
}