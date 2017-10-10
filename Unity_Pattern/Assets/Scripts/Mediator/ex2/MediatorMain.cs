using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MediatorPattern.ex2
{
    public class MediatorMain : MonoBehaviour
    {

        void Main()
        {
            User dean = new User("Dean");
            User yuri = new User("Yuri");

            dean.SendMessage("Hi! Yuri");
            yuri.SendMessage("Hello! Dean");
        }
    }
}
