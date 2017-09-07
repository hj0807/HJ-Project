using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FatoryMethodPattern
{
    public class BaseTest : MonoBehaviour
    {
        void Start()
        {
            Creator[] creators = new Creator[2];

            creators[0] = new ConcreteCreatorA();
            creators[1] = new ConcreteCreatorB();

            for(int i=0; i<creators.Length; i++)
            {
                Product product = creators[i].FactoryMethod();
                Debug.Log("Created " + product.GetType().Name);
            }
        }
    }

    public abstract class Product
    {

    }

    public class ConcreteProductA : Product
    {

    }

    public class ConcreteProductB : Product
    {

    }

    public abstract class Creator
    {
        public abstract Product FactoryMethod();
    }

    public class ConcreteCreatorA : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }

    public class ConcreteCreatorB : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }
}
