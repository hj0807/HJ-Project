using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlyweightPattern.ex2
{
    public class MainProgram : MonoBehaviour
    {
        private static CoffeeFlavor[] flavors = new CoffeeFlavor[100];

        private static CoffeeOrderContext[] tables = new CoffeeOrderContext[100];

        private static int ordersMade = 0;

        private static CoffeeFlavorFactory flavorFactory;

        public static void TakeOrders(string flavor, int tableNum)
        {
            flavors[ordersMade] = flavorFactory.GetCoffeeFlavor(flavor);
            tables[ordersMade++] = new CoffeeOrderContext(tableNum);
        }

        void Main()
        {
            flavorFactory = new CoffeeFlavorFactory();

            TakeOrders("Cappuccino", 2);
            TakeOrders("Cappuccino", 2);

            TakeOrders("Frappe", 1);
            TakeOrders("Frappe", 1);

            TakeOrders("Xpresso", 1);
            TakeOrders("Frappe", 897);
            TakeOrders("Cappuccino", 97);
            TakeOrders("Cappuccino", 97);
            TakeOrders("Frappe", 3);
            TakeOrders("Xpresso", 3);
            TakeOrders("Cappuccino", 3);
            TakeOrders("Xpresso", 96);
            TakeOrders("Frappe", 552);
            TakeOrders("Cappuccino", 121);
            TakeOrders("Xpresso", 121);

            for(int i=0; i<ordersMade; i++)
            {
                flavors[i].ServeCoffee(tables[i]);
            }

            Debug.Log("실제 생성된 coffeeFlavor 객체 갯수 : " + flavorFactory.GetCoffeeFlavorCount());
        }
    }
}