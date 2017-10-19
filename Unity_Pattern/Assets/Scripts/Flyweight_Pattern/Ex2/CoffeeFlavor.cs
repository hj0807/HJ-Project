using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlyweightPattern.ex2
{
     /// <summary>
     /// Concrete Flyweight 객체
     /// Flyweight 인터페이스를 구현.
     /// 공유하는 객체, 여러개가 존재할 수 있다.
     /// </summary>
    public class CoffeeFlavor : ICoffeeOrder
    {
        private string flavor;

        public CoffeeFlavor(string flavor)
        {
            this.flavor = flavor;
        }

        public void ServeCoffee(CoffeeOrderContext context)
        {
            Debug.Log(string.Format("[{0}] 커피 주문 완료 - 테이블 번호 : {1}", flavor, context.GetTableNumber()));
        }

        public string GetFlavor()
        {
            return flavor;
        }
    }
}
