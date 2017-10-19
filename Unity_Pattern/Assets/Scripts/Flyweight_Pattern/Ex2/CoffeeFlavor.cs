using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlyweightPattern.ex2
{
    /// <summary>
    /// Concrete Flyweight 객체
    /// Flyweight 인터페이스를 구현.
    /// 이 ConcreteFlyweight 객체는 공유할 수 있어야한다.
    /// </summary>
    public class CoffeeFlavor : ICoffeeOrder
    {
        private string flavor;

        public CoffeeFlavor(string flavor)
        {
            this.flavor = flavor;
        }

        public void ServeCoffee(CoffeeOrderContext context)
        {
            Debug.Log("Serving Coffee flavor : " + flavor + " to table number : " + context.GetTableNumber());
        }

        public string GetFlavor()
        {
            return flavor;
        }
    }
}
