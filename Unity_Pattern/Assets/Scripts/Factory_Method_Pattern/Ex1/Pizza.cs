using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

//namespace FactoryMethodPattern
    public abstract class Pizza
    {
        protected string name;
        protected string dough;
        protected string sauce;

        protected ArrayList toppings = new ArrayList();

        public void Prepare()
        {
            Debug.Log("[Preparing] " + name);
            Debug.Log("[Tossing dough] " + dough);
            Debug.Log("[Adding sauce] " + sauce);

            Debug.Log("[Adding toppinegs] ");

            for (int i = 0; i < toppings.Count; i++)
            {
                Debug.Log(string.Format("topping {0} : {1}", i, toppings[i]));
            }
        }

        public void Bake()
        {
            Debug.Log("Baking default");
        }

        public void Cut()
        {
            Debug.Log("Cutting the pizza into 8 pieces");
        }

        public void Box()
        {
            Debug.Log("Boxing default");
        }

        public string GetName()
        {
            return name;
        }
    }
