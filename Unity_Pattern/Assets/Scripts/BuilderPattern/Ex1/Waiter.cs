
using UnityEngine;

namespace BuilderPattern.ex1
{
    public class Waiter 
    {
        private PizzaBuilder pizzaBuilder;

        public void SetPizzaBuilder(PizzaBuilder builder)
        {
            pizzaBuilder = builder;
        }

        public Pizza GetPizza()
        {
            return pizzaBuilder.GetPizza();
        }

        public void ConstructPizza()
        {
            pizzaBuilder.CreateNewPizza();
            pizzaBuilder.BuildDough();
            pizzaBuilder.BuildSauce();
            pizzaBuilder.BuildTopping();

            Debug.Log("ConstructPizza : " + pizzaBuilder);
        }
    }
}
