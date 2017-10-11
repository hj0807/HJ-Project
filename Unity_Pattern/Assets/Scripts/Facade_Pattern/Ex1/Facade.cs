using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FacadePattern.ex1
{
    public class Facade : MonoBehaviour
    {
        SubSystemOne one;
        SubSystemTwo two;
        SubSystemThree three;
        SubSystemFour four;

        public Facade()
        {
            one = new SubSystemOne();
            two = new SubSystemTwo();
            three = new SubSystemThree();
            four = new SubSystemFour();
        }

        public void MethodA()
        {
            Debug.Log("MethodA 실행");

            one.MethodOne();
            two.MethodTwo();
            four.MethodFour();
        }

        public void MethodB()
        {
            Debug.Log("MethodB 실행");

            two.MethodTwo();
            three.MethodThree();
        }
    }
}
