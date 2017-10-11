using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FacadePattern.ex1
{
    public class MainProgram : MonoBehaviour
    {
        void Start()
        {
            Facade facade = new Facade();

            facade.MethodA();
            facade.MethodB();

        }
    }
}