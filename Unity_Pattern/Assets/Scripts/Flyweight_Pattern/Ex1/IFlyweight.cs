using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlyweightPattern.ex1
{
    public interface IFlyweight {
        void Operation(int size);
    }

    public class ConcreteFlyweight : IFlyweight
    {
        public void Operation(int size)
        {
            Debug.Log("ConcreteFlyweight : " + size);
        }
    }

    public class UnSharedConcreteFlyweight : IFlyweight
    {
        public void Operation(int size)
        {
            Debug.Log("UnSharedConcreteFlyweight : " + size);
        }
    }
}