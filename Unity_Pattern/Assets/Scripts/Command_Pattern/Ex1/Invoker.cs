using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommandPattern.ex1
{
    /// <summary>
    /// 클라이언트의 Command 객체를 Receiver에 전달.
    /// 실행 명령 객체 요청.
    /// </summary>
    public class Invoker
    {
        private Command command;

        public Invoker(Command command)
        {
            this.command = command;
        }

        public void ExecuteCommand()
        {
            command.Execute();
        }
    }
}
