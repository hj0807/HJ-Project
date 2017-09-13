using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NYPizzaStore : PizzaStore
{
    public override Pizza CreatePizza(string name)
    {
        if (name.Equals("cheese"))
            return new NYStyleCheesePizza();

        return null;
    }
}
