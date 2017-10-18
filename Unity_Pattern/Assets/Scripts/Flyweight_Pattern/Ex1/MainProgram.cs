using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlyweightPattern.ex1
{
    public class MainProgram : MonoBehaviour {

        void Main()
        {
            int size = 22;

            FlyweightFactory factory = new FlyweightFactory();

            IFlyweight fx = factory.GetFlyweight("X");
            fx.Operation(--size);

            IFlyweight fy = factory.GetFlyweight("Y");
            fy.Operation(--size);

            IFlyweight fz = factory.GetFlyweight("Z");
            fz.Operation(--size);

            IFlyweight fu = new UnSharedConcreteFlyweight();
            fu.Operation(--size);

        }
    }
}