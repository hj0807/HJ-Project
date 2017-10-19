using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlyweightPattern.ex2
{
    /// <summary>
    /// 테이블 정보(번호)를 가지고 있는 객체.
    /// 해당 클래스는 Flyweight 구조에서 중요하지 않음.
    /// </summary>
    public class CoffeeOrderContext
    {
        private int tableNumber;

        public CoffeeOrderContext(int tableNumber)
        {
            this.tableNumber = tableNumber;
        }

        public int GetTableNumber()
        {
            return tableNumber;
        }
    }
}