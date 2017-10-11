using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SingletonPattern.ex1
{
    public class testMgr : Singleton<testMgr>
    {
        public void Print()
        {
            Debug.Log("테스트용으로 출력한다.");

            Debug.Log(Instance);
        }
    }
}
