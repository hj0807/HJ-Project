﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MediatorPattern.ex2
{
    /// <summary>
    /// Concrete Colleague
    /// 실제 객체를 구현하는 클래스.
    /// </summary>
    public class RankerUser : UserBase
    {
        public RankerUser(string name) : base(name)
        {
        }

        public override void ReceiveMessage(string from, string message)
        {
            Debug.Log(string.Format("[랭커 유저] {0} -> {1} : {2}", from, this.Name, message));
        }
    }
}
