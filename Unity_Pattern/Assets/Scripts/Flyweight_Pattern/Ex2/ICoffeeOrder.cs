using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlyweightPattern.ex2
{

    //커피전문점을 예로 들 수 있다.
    //주문한 테이블 번호마다 어떤 커피를 시켰는지 기록한다고 가정하면
    //각 테이블마다 커피에 대한 객체를 만들도록 하면 테이블수*해당 테이블 커피수 만큼의 인스턴스가 필요하다.
    //그래서 커피를 flyweight로 적용해본다.
    //참고 https://m.blog.naver.com/PostView.nhn?blogId=whdahek&logNo=70152211468&proxyReferer=https%3A%2F%2Fwww.google.co.kr%2F
    //검색 flyweight pattern servecoffee

    /// <summary>
    /// Flyweight 객체 인터페이스.
    /// </summary>
    public interface ICoffeeOrder
    {
        void ServeCoffee(CoffeeOrderContext context);
    }
}