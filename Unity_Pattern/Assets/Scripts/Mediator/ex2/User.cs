using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MediatorPattern.ex2
{
    public class User : MonoBehaviour
    {

        private string name;


        public User(string name)
        {
            this.name = name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public void SendMessage(string msg)
        {
            ChatRoom.ShowMessage(this, msg);
        }
    }
}
