using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommandPattern.ex1
{
    /// <summary>
    /// 명령 추상 클래스.
    /// </summary>
    public abstract class Command 
    {
        //Receiver 객체를 참조.
        //명령은 접수자가 누군지 반드시 알아야함.
        protected Receiver receiver;

        //생성자를 통해 리시버 전달.
        public Command(Receiver receiver)
        {
            this.receiver = receiver;
        }

        //모든 명령 객체들이 구현해야하는 실행 메서드.
        public abstract void Execute();
    }
}