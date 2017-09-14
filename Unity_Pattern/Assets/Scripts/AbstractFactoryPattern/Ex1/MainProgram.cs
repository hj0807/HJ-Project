using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AbstractFactoryPattern.ex1
{
    public class MainProgram : MonoBehaviour
    {
        void Start()
        {
            AbstractFactory f1 = new ConcreteFactory1();
            Client c1 = new Client(f1);
            c1.Run();

            //AbstractFactory f2 = new ConcreteFactory2();
            //Client c2 = new Client(f2);
            //c2.Run();
        }
    }

    public class Client
    {
        private AbstractProductA _A;
        private AbstractProductB _B;

        public Client(AbstractFactory factory)
        {
            _A = factory.CreateProductA();
            _B = factory.CreateProductB();
        }

        public void Run()
        {
            _B.Interact(_A);
        }
    }

}