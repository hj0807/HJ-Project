using UnityEngine;

namespace BuilderPattern.ex1
{
    public class MainProgram : MonoBehaviour
    {
        private void Start()
        {
            Waiter waiter = new Waiter();
            waiter.SetPizzaBuilder(new HawaiianPizzaBuilder());
            waiter.ConstructPizza();

            waiter.SetPizzaBuilder(new SpicyPizzaBuilder());
            waiter.ConstructPizza();
        }
    }
}