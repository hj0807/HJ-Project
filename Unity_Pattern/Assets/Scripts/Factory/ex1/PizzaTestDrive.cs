using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaTestDrive : MonoBehaviour {

    /// <summary>
    /// 팩토리 메소드 패턴
    /// 객체를 생성하기위한 인터페이스를 정의.
    /// 어떤 클래스의 인스턴스를 만들지는 서브클래스에서 결정.
    /// 
    /// 객체 생성 코드를 전부 한 메소드에서 처리하면 중복되는 내용 제거 가능.
    /// 관리도 용이
    /// 객체 생성시 각 클래스가 아닌 인터페이스만 필요.
    /// </summary>
	void Start () {
        Main();
	}

    private void Main()
    {
        PizzaStore nyStore = new NYPizzaStore();
        PizzaStore chicagoStore = new ChicagoPizzaStore();

        Pizza pizza = nyStore.OrderPizza("cheese");
        Debug.Log("Jenny ordered a " + pizza.GetName());

        pizza = chicagoStore.OrderPizza("cheese");
        Debug.Log("John ordered a " + pizza.GetName());
    }
}
