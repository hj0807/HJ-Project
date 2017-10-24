using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommandPattern.ex3
{
    /// <summary>
    /// Command 인터페이스.
    /// 커맨드 객체는 해당 인터페이스를 상속받아 구현한다.
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// 실행 메소드. 
        /// on,off를 경우에 따라 구현할 클래스에서 세부 기능 구현.
        /// </summary>
        void Execute();

        void Undo();
    }
}
