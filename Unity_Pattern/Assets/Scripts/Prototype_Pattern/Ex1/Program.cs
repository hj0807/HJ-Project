using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PrototypePattern.ex1
{
    public class Program : MonoBehaviour
    {
        void Start()
        {
            //A.
            ConcreatePrototypeA productA = new ConcreatePrototypeA("product1");
            ConcreatePrototypeA cloneA = productA.Clone() as ConcreatePrototypeA;

            Debug.Log(string.Format("Clone A : {0}", cloneA.Id));

            //B.
            ConcreatePrototypeB productB = new ConcreatePrototypeB("product2");
            ConcreatePrototypeB cloneB = productB.Clone() as ConcreatePrototypeB;

            Debug.Log(string.Format("Clone B : {0}", cloneB.Id));

        }
    }
}