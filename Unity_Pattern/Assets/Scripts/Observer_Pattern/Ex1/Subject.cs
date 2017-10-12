using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverPattern.ex1
{
    /// <summary>
    /// 관찰되는 객체
    /// 관찰자인 Observer 역할을 등록하는 메소드와 
    /// 삭제하는 메소드를 가진다.
    /// </summary>
    public abstract class Subject
    {
        private List<Observer> observerList = new List<Observer>();

        public void Attach(Observer observer)
        {
            observerList.Add(observer);
        }

        public void Detach(Observer observer)
        {
            observerList.Remove(observer);
        }

        public void Notify()
        {
            for(int i=0; i<observerList.Count; i++)
            {
                observerList[i].Update();
            }
        }
    }
}
