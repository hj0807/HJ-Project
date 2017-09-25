using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VisitorPattern.ex1
{
    /// <summary>
    /// 데이터 인터페이스.
    /// accept 메서드 제공
    /// </summary>
    public interface ICarElement
    {
        void Accept(ICarElementVisitor visitor);
    }

    public class Body : ICarElement
    {
        public void Accept(ICarElementVisitor visitor)
        {
            visitor.visit(this);
        }
    }

    public class Engine : ICarElement
    {
        public void Accept(ICarElementVisitor visitor)
        {
            visitor.visit(this);
        }
    }
}