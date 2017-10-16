using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatePattern.ex2
{
    public class MainProgram : MonoBehaviour
    {
        void Main()
        {
            SiegeTank tank = new SiegeTank(new NormalState());

            tank.Attack();
            tank.Move();

            Debug.Log("===================");

            tank.Attacked("Medic Blind");

            tank.Attack();
            tank.Move();

            Debug.Log("===================");

            tank.Attacked("Ghost LockDown");

            tank.Attack();
            tank.Move();
        }
    }
}
