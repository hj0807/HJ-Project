using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheesePizza : Pizza {

    public CheesePizza()
    {
        name = "Cheese Pizza";
        dough = "Regular Crust";
        sauce = "Marinara Pizza Sauce";

        toppings.Add("Fresh Mozzarella");
        toppings.Add("Parmesan");
    }
}