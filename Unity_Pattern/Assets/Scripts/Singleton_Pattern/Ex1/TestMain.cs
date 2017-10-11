using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SingletonPattern.ex1
{
    public class TestMain : MonoBehaviour
    {
        void Start()
        {
            OperatorMgr.Instance.AddValue(30);
            OperatorMgr.Instance.AddValue(50);

            OperatorMgr.Instance.Print();

            testMgr.Instance.Print();

        }
    }
}