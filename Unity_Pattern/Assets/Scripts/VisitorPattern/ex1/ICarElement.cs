using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VisitorPattern.ex1
{
    /// <summary>
    /// Element 역할
    /// 데이터 인터페이스.
    /// visitor를 전달받는 Accept 메서드 제공
    /// </summary>
    public interface ICarElement
    {
        void Accept(ICarElementVisitor visitor);
    }

    /// <summary>
    /// ConcreteElement 역할
    /// </summary>
    public class Body : ICarElement
    {
        //visitor에 자기 자신을 전달.
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