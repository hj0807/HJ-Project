using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommandPattern.ex1
{
    public class Receiver
    {
        public void Action()
        {
            Debug.Log("Called Receiver.Action()");
        }
    }
}
