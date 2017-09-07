using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChicagoStyleCheesePizza : Pizza {
    public ChicagoStyleCheesePizza()
    {
        name = "Chicago Style Cheese Pizza";
        dough = "Extra thick crust dough";
        sauce = "tomato sauce";

        toppings.Add("slice cheese");
    }

    /// <summary>
    /// Cut을 오버라이드하여, 4조각으로 slice하도록.
    /// </summary>
    void Cut()
    {
        Debug.Log("Cutting the pizza into 4 pieces");
    }
}
