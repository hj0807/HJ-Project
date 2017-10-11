using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//행위패턴, 방문자패턴
//http://arisu1000.tistory.com/27696

namespace VisitorPattern.ex1
{
    /// <summary>
    /// Visit 인터페이스
    /// Concrete Element를 전달받는 visit 메소드를 제공.
    /// </summary>
    public interface ICarElementVisitor 
    {
        //ConcreteElement에 대해 visit 메소드를 추가.
        void visit(Body body);
        void visit(Wheel wheel);
        void visit(Engine engine);
        void visit(Car car);
    }
}