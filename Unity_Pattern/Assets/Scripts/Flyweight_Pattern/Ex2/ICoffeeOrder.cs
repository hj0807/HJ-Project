using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlyweightPattern.ex2
{
    /// <summary>
    /// Flyweight 객체 인터페이스.
    /// </summary>
    public interface ICoffeeOrder
    {
        void ServeCoffee(CoffeeOrderContext context);
    }
}