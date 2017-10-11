using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MementoPattern.ex1
{
    public class MainProgram : MonoBehaviour
    {
        void Main()
        {
            Originator originator = new Originator();
            CareTaker careTaker = new CareTaker();

            originator.SetState("State 1");
            originator.SetState("State 2");
            careTaker.Add(originator.SaveStateToMemento());

            originator.SetState("State 3");
            careTaker.Add(originator.SaveStateToMemento());

            originator.SetState("State 4");
            Debug.Log("Current State : " + originator.GetState());

            originator.GetStateFromMemento(careTaker.Get(0));
            Debug.Log("First saved state : " + originator.GetState());

            originator.GetStateFromMemento(careTaker.Get(1));
            Debug.Log("Second saved state : " + originator.GetState());
        }
    }
}
