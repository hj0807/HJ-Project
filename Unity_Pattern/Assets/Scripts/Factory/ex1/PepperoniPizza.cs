﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PepperoniPizza : Pizza
{
    public PepperoniPizza()
    {
        name = "Pepperoni Pizza";
        dough = "Crust";
        sauce = "Marinara sauce";

        toppings.Add("Sliced Pepperoni");
        toppings.Add("Sliced Onion");
        toppings.Add("Grated parmesan cheese");
    }
}