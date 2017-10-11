using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AbstractFactoryPattern.ex1
{
    public abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();
    }

    public abstract class AbstractProductA
    {
    }

    public abstract class AbstractProductB
    {
        public abstract void Interact(AbstractProductA a);
    }

    public class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }



    public class ProductA1 : AbstractProductA
    {

    }

    public class ProductB1 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Debug.Log(this.GetType().Name + " interacts with " + a.GetType().Name);
        }
    }

    //public class ConcreteFactory2 : AbstractFactory
    //{
    //    public override AbstractProductA CreateProductA()
    //    {
    //        return new ProductA2();
    //    }

    //    public override AbstractProductB CreateProductB()
    //    {
    //        return new ProductB2();
    //    }
    //}


    //public class ProductA2 : AbstractProductA
    //{

    //}

    //public class ProductB2 : AbstractProductB
    //{
    //    public override void Interact(AbstractProductA a)
    //    {
    //        Debug.Log(this.GetType().Name + " interacts with " + a.GetType().Name);
    //    }
    //}
}