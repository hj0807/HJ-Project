using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlyweightPattern.ex2
{
    /// <summary>
    /// Flyweight Factory 객체.
    /// Flyweight 객체를 생성하고, 관리한다.
    /// </summary>
    public class CoffeeFlavorFactory
    {
        //ConcreteFlyweight 객체를 관리하는 Dictionary.
        private Dictionary<string, CoffeeFlavor> flavors = new Dictionary<string, CoffeeFlavor>();

        public CoffeeFlavor GetCoffeeFlavor(string flavorName)
        {
            CoffeeFlavor flavor;

            //Flyweight 객체가 존재하지 않으면 생성.
            if (!flavors.ContainsKey(flavorName))
            {
                flavor = new CoffeeFlavor(flavorName);

                flavors.Add(flavorName, flavor);
            }
            else //객체가 존재하면 재사용한다.
            {
                flavor = flavors[flavorName];
            }

            return flavor;
        }

        public int GetCoffeeFlavorCount()
        {
            return flavors.Count;
        }
    }
}
