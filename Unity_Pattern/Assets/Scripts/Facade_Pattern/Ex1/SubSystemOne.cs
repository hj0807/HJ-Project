using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FacadePattern.ex1
{
    public class SubSystemOne
    {
        public void MethodOne()
        {
            Debug.Log("1번 시스템 작동");
        }

    }

    public class SubSystemTwo
    {
        public void MethodTwo()
        {
            Debug.Log("2번 시스템 작동");
        }
    }

    public class SubSystemThree
    {
        public void MethodThree()
        {
            Debug.Log("3번 시스템 작동");
        }
    }

    public class SubSystemFour
    {
        public void MethodFour()
        {
            Debug.Log("4번 시스템 작동");
        }
    }
}