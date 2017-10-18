using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlyweightPattern.ex2
{
    /// <summary>
    /// Concrete Flyweight 객체
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
