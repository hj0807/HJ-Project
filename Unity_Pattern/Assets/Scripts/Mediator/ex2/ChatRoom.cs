using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MediatorPattern.ex2
{
    public class ChatRoom
    {
        public static void ShowMessage(User user, string msg)
        {
            Debug.Log(System.DateTime.Now.ToString() + " [" + user.GetName() + "] : " + msg);
        }
    }
}