using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//주석 : http://aroundck.tistory.com/4603
//http://www.dofactory.com/net/visitor-design-pattern
//https://www.codeproject.com/Articles/872151/Visitor-Pattern-ReExplained 예제
//http://dorkasaurusrex.blogspot.kr/2009/10/implementing-visitor-pattern-pattern-in.html

namespace VisitorPattern.ex1
{
    /// <summary>
    /// Visitor Pattern.
    /// 2개의 interface가 필요 (IElemnt, Ivisitor)
    /// </summary>
    public class MainProgram : MonoBehaviour
    {
        void Start()
        {
            ICarElement car = new Car();

            car.Accept(new CarElementPrintVisitor());
            car.Accept(new CarElementDoVisitor());
        }
    }
}