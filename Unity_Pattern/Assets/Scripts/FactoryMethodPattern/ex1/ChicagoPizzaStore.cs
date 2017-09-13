using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChicagoPizzaStore : PizzaStore
{
    public override Pizza CreatePizza(string name)
    {
        if (name.Equals("cheese"))
            return new ChicagoStyleCheesePizza();

        return null;
    }
}
