using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MementoPattern.ex1
{
    //Memento를 관리하는 객체.
    public class CareTaker : MonoBehaviour
    {
        private List<Memento> mementoList = new List<Memento>();

        public void Add(Memento memento) {
            mementoList.Add(memento);
        }

        public Memento GetData(int index) {
            if (index < mementoList.Count) { 
                return mementoList[index];
            }
            return null;
        }
    }
}