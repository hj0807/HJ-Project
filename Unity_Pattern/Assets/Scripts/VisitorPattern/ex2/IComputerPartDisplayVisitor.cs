using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VisitorPattern.ex2
{
    /// <summary>
    /// Concrete Visitor 역할
    /// Element 인터페이스 역할 (데이터의 인터페이스)
    /// 
    /// 각 객체는 Visitor 객체가 세부 작업을 처리할 수 있도록 
    /// Visitor 인터페이스를 받아야한다.
    /// </summary>
    public interface IComputerPart
    {
        void Accept(IComputerPartVisitor visitor);
    }

    /// <summary>
    /// Concrete Element 역할 
    /// IComputerPart의 구현 클래스
    /// </summary>
    public class Monitor : IComputerPart
    {
        // Visitor에 자기 자신을 전달 (Visitor가 해당 객체의 세부작업을 처리할 수 있도록)
        public void Accept(IComputerPartVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    /// <summary>
    /// Concrete Element 역할 
    /// IComputerPart의 구현 클래스
    /// </summary>
    public class Keyboard : IComputerPart
    {
        public void Accept(IComputerPartVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    /// <summary>
    /// Concrete Element 역할 
    /// IComputerPart의 구현 클래스
    /// </summary>
    public class Mouse : IComputerPart
    {
        public void Accept(IComputerPartVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    /// <summary>
    /// Concrete Element 역할
    /// IComputerPart의 구현 클래스
    /// 
    /// 복잡한 구조체 (부품들을 가지고 있음) - Composite 패턴과 유사.
    /// 이 구조체를 사용하고 싶을 때 Visitor를 통해서 내부 로직에 접근한다.
    /// </summary>
    public class Computer : IComputerPart
    {
        private IComputerPart[] parts;

        // 부품을 생성한다.
        public Computer()
        {
            parts = new IComputerPart[] { new Monitor(), new Keyboard(), new Mouse() };
        }

        public void Accept(IComputerPartVisitor visitor)
        {
            for(int i=0; i<parts.Length; i++) {
                parts[i].Accept(visitor);
            }
            visitor.Visit(this);
        }
    }
}