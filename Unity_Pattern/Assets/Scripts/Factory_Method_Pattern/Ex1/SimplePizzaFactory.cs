using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplePizzaFactory
{
    public Pizza CreatePizza(string type)
    {
        Pizza pizza = null;

        if (type.Equals("cheese"))
        {
            pizza = new CheesePizza();
        }
        else if (type.Equals("pepperoni"))
        {
            pizza = new PepperoniPizza();
        }
        return pizza;
    }
}
