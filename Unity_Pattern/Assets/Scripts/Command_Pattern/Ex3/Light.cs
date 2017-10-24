using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommandPattern.ex3
{
    /// <summary>
    /// 기본적인 조명 클래스.
    /// </summary>
    public class Light
    {
        public Light()
        {
        }

        public void on()
        {
            Debug.Log("Light is on");
        }

        public void off()
        {
            Debug.Log("Light is off");
        }
    }
}
