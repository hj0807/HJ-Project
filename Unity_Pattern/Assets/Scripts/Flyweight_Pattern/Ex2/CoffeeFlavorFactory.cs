using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlyweightPattern.ex2
{
    //Flyweight Factory 객체.
    public class CoffeeFlavorFactory
    {
        private Dictionary<string, CoffeeFlavor> flavors = new Dictionary<string, CoffeeFlavor>();

        public CoffeeFlavor GetCoffeeFlavor(string flavorName)
        {
            CoffeeFlavor flavor;

            if (!flavors.ContainsKey(flavorName))
            {
                flavor = new CoffeeFlavor(flavorName);

                flavors.Add(flavorName, flavor);
            }
            else
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
