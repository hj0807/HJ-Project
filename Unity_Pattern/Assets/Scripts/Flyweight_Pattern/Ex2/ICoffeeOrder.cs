using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlyweightPattern.ex2
{   
    /// <summary>
    /// Flyweight 객체 인터페이스.
    /// 공유할 객체들이 공통적으로 가지고 있는 메소드를 가지고 있음.
    /// </summary>
    public interface ICoffeeOrder
    {
        void ServeCoffee(CoffeeOrderContext context);
    }
}