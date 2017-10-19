# Flyweight Pattern ( 패턴) 



## 1. Flyweight Pattern 
- [구조패턴]

- **데이터를 공유**하여 _메모리를 절약_ 할 수 있는 패턴.

- 한번 생성된 객체는 두번 생성되는 것이 아니라, 풀(Pool)에 의해서 관리 및 사용된다.

- 어떤 클래스의 인스턴스 한개만 가지고 여러개의 가상 인스턴스를 제공하고 싶을 때 사용하는 패턴

- 객체가 필요할 때 마다 new로 매번 만들게 되면 메모리 사용량이 커진다는 문제가 발생! => 객체를 공유하여 사용하도록.

  ​



## 2. UML Diagram
![uml](http://www.lepus.org.uk/spec/gof/uml/Flyweight.png)



## 3. 장/단점

### [장점]


- 객체의 인스턴스 갯수를 줄여서 메모리를 절약 가능.




### [단점]

- **특정 인스턴스**만 다른 인스턴스와 **다른식으로 행동하는 것이 불가능**함.
  - 어떤 인스턴스가 많이 필요하나 모두 똑같은 방식으로 제어할 수 있는 경우에 유용.





## 4. 코드 설명

- 카페에서 주문한 테이블 번호(CoffeeOrderContext) 마다 어떤 커피를 시켰는지 기록을 한다고 가정.

- 각 테이블마다 커피 객체를 만든다면 (테이블수 * 해당 테이블에서 주문한 커피수) 만큼의 객체가 필요함. 

- 데이터를 공유하여(CoffeFlavorFactory) 커피(CoffeeFlavor)를 Flyweight로 적용해서 객체 수를 줄여본다.

  ​



### [CoffeeOrderContext.cs]

~~~~c#
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
~~~~



### [ICoffeeOrder.cs]

~~~~c#
       
    /// <summary>
    /// Flyweight 객체 인터페이스.
    /// 공유할 객체들이 공통적으로 가지고 있는 메소드를 가지고 있음.
    /// </summary>
    public interface ICoffeeOrder
    {
        void ServeCoffee(CoffeeOrderContext context);
    }
~~~~



### [CoffeeFlavor.cs]

~~~~c#
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
~~~~



### [CoffeeFlavorFactory.cs]

```c#
    /// <summary>
    /// Flyweight Factory 객체.
    /// Flyweight 객체를 생성하고, 관리한다 (Pooling)
    /// </summary>
    public class CoffeeFlavorFactory
    {
        //ConcreteFlyweight 객체를 관리하는 Dictionary.
        private Dictionary<string, CoffeeFlavor> flavors = new Dictionary<string, CoffeeFlavor>();

        public CoffeeFlavor GetCoffeeFlavor(string flavorName)
        {
            CoffeeFlavor flavor;

            //Flyweight 객체가 존재하지 않으면 생성.
            if (!flavors.ContainsKey(flavorName))
            {
                flavor = new CoffeeFlavor(flavorName);

                flavors.Add(flavorName, flavor);
            }
            else //객체가 존재하면 재사용한다.
            {
                flavor = flavors[flavorName];
            }

            return flavor;
        }

        public int GetCoffeeFlavorCount()
        {
            return flavors.Count;
        }
    }
```



### [CoffeeFlavorFactory.cs]

```c#
    /// <summary>
    /// Flyweight Factory 객체.
    /// Flyweight 객체를 생성하고, 관리한다 (Pooling)
    /// </summary>
    public class CoffeeFlavorFactory
    {
        //ConcreteFlyweight 객체를 관리하는 Dictionary.
        private Dictionary<string, CoffeeFlavor> flavors = new Dictionary<string, CoffeeFlavor>();

        public CoffeeFlavor GetCoffeeFlavor(string flavorName)
        {
            CoffeeFlavor flavor;

            //Flyweight 객체가 존재하지 않으면 생성.
            if (!flavors.ContainsKey(flavorName))
            {
                flavor = new CoffeeFlavor(flavorName);

                flavors.Add(flavorName, flavor);
            }
            else //객체가 존재하면 재사용한다.
            {
                flavor = flavors[flavorName];
            }

            return flavor;
        }

        public int GetCoffeeFlavorCount()
        {
            return flavors.Count;
        }
    }
```



### [MainProgram.cs]

```c#
    public class MainProgram : MonoBehaviour
    {
        private static CoffeeFlavor[] flavors = new CoffeeFlavor[100];
        private static CoffeeOrderContext[] tables = new CoffeeOrderContext[100];

        private static int ordersMade = 0;

        private static CoffeeFlavorFactory flavorFactory;

        void Main()
        {
            //Flyweight를 관리하는 CoffeeFlavorFactory 객체를 생성.
            flavorFactory = new CoffeeFlavorFactory();

            //테이블 번호에서 어떤 커피를 주문했는지 정보를 입력받는다.
            TakeOrders("Cappuccino", 2);
            TakeOrders("Cappuccino", 2);

            TakeOrders("Frappe", 1);
            TakeOrders("Frappe", 1);

            TakeOrders("Xpresso", 1);
            TakeOrders("Frappe", 897);
            TakeOrders("Cappuccino", 97);
            TakeOrders("Cappuccino", 97);
            TakeOrders("Frappe", 3);
            TakeOrders("Xpresso", 3);
            TakeOrders("Cappuccino", 3);
            TakeOrders("Xpresso", 96);
            TakeOrders("Frappe", 552);
            TakeOrders("Cappuccino", 121);
            TakeOrders("Xpresso", 121);

            for(int i=0; i<ordersMade; i++)
            {
                flavors[i].ServeCoffee(tables[i]);
            }

            Debug.Log("===========================");
            Debug.Log("실제 생성된 coffeeFlavor 객체 갯수 : " + flavorFactory.GetCoffeeFlavorCount());
        }

        public static void TakeOrders(string flavor, int tableNum)
        {
            //flavorFactory 객체의 리스트에서 해당 객체가 존재하면 반환,없으면 생성해서 반환.
            flavors[ordersMade] = flavorFactory.GetCoffeeFlavor(flavor);
            tables[ordersMade++] = new CoffeeOrderContext(tableNum);
        }
    }
```



---


### [실행 결과]

	[Cappuccino] 커피 주문 완료 - 테이블 번호 : 2
	[Cappuccino] 커피 주문 완료 - 테이블 번호 : 2
	[Frappe] 커피 주문 완료 - 테이블 번호 : 1
	[Frappe] 커피 주문 완료 - 테이블 번호 : 1
	[Xpresso] 커피 주문 완료 - 테이블 번호 : 1
	[Frappe] 커피 주문 완료 - 테이블 번호 : 897
	[Cappuccino] 커피 주문 완료 - 테이블 번호 : 97
	[Cappuccino] 커피 주문 완료 - 테이블 번호 : 97
	[Frappe] 커피 주문 완료 - 테이블 번호 : 3
	[Xpresso] 커피 주문 완료 - 테이블 번호 : 3
	[Cappuccino] 커피 주문 완료 - 테이블 번호 : 3
	[Xpresso] 커피 주문 완료 - 테이블 번호 : 96
	[Frappe] 커피 주문 완료 - 테이블 번호 : 552
	[Cappuccino] 커피 주문 완료 - 테이블 번호 : 121
	[Xpresso] 커피 주문 완료 - 테이블 번호 : 121
	===========================
	실제 생성된 coffeeFlavor 객체 갯수 : 3

- 총 15개 객체가 생성된 것 같아보이지만 실질적으로는 객체가 3개만 생성되고 이를 재사용하였다.




## 5.참고사이트

- https://m.blog.naver.com/PostView.nhn?blogId=whdahek&logNo=70152211468&proxyReferer=https%3A%2F%2Fwww.google.co.kr%2F