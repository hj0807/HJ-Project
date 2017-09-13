using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPizzaIngredientFactory
{
    IDough CreateDought();
    ISauce CreateSauce();
    ICheese CreateCheese();
    IVeggies[] CreateVeggies();
    IPepperoni CreatePepperoni();
    IClams CreateClams();
}
