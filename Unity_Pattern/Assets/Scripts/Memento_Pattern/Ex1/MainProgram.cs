using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MementoPattern.ex1
{
    public class MainProgram : MonoBehaviour
    {
        void Main()
        {
            CareTaker careTaker = new CareTaker();

            Originator originator = new Originator();
            originator.SetState("상태 1");
            originator.SetState("상태 2");

            careTaker.Add(originator.SaveStateToMemento());


            originator.SetState("상태 3");

            careTaker.Add(originator.SaveStateToMemento());


            originator.SetState("상태 4");

            Debug.Log("Current State : " + originator.GetState());

            originator.GetStateFromMemento(careTaker.GetData(0));
            Debug.Log("First saved state : " + originator.GetState());

            originator.GetStateFromMemento(careTaker.GetData(1));
            Debug.Log("Second saved state : " + originator.GetState());
        }
    }
}