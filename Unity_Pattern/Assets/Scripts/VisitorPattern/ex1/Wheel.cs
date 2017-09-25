using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace VisitorPattern.ex1
{
    /// <summary>
    /// 데이터 클래스
    /// Visit에게 자신을 전달.
    /// </summary>
    public class Wheel : ICarElement
    {
        private string name;

        public Wheel(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public void Accept(ICarElementVisitor visitor)
        {
            visitor.visit(this);
        }
    }
}
