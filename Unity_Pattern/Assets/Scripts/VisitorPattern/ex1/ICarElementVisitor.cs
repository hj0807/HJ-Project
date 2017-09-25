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
    /// </summary>
    public interface ICarElementVisitor 
    {
        void visit(Body body);
        void visit(Wheel wheel);
        void visit(Engine engine);
        void visit(Car car);
    }
}