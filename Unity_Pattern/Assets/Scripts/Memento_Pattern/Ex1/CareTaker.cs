using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MementoPattern.ex1
{
    public class CareTaker : MonoBehaviour
    {
        private List<Memento> mementoList = new List<Memento>();

        public void Add(Memento state)
        {
            mementoList.Add(state);
        }

        public Memento Get(int index)
        {
            return mementoList[index];
        }
    }
}