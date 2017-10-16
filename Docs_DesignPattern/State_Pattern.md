# State Pattern (상태 패턴) 



## 1. State Pattern 

- [행위패턴]
- **객체의 상태**에 따라 **객체의 행동**을 바꿀 수 있는 패턴.
- _알고리즘의 개별 단계_ 를 어떻게 구현할지를 _서브클래스에서 결정_ 한다.
- 하나의 객체를 통해 여러 상태를 가질 수 있다.



## 2. UML Diagram
![uml](http://www.dofactory.com/images/diagrams/net/state.gif)

- Context : 객체의 내부 상태를 정의하는 Concrete State를 관리한다.
- State : 객체의 특정 상태와 관련된 행동을 캡슐화하기 위한 인터페이스를 정의.
- Concrete State : State에 따른 동작을 구현하는 서브 클래스.



## 3. 장/단점

### [장점]


- 클라이언트는 상태 변환을 신경쓰지 않아도 된다. 

  - 각 서브클래스에서 상태를 변환하기때문에.
- 새로운 상태 객체를 추가하기가 쉽다.

  - Concrete State 객체를 추가하면 된다.




### [단점]

- 불필요하게 클래스가 많아질 수도 있다.
  - 상태를 나타내는 모든 객체를 클래스로 만들어야하기 때문에 
  - 객체 상태의 종류가 얼마나 추가될지를 고려해서 해당 패턴을 쓰는 것을 결정해야한다.
- 조건문, 분기문에 비해서 명시적이지 않다.
- State 객체간에 서로 참조해야하는 문제가 발생한다.



## 4. 코드 설명

- Gumball을 파는 뽑기 기계가 있다. 동전을 투입하고, 손잡이를 돌리면 Gumball이 나오는 방식이다.

- 뽑기 기계(GumballMachine)의 상태(NoCoin, HasCoin, Sold, SoldOut) 에 따라서 각각의 행동을 정의한다.

  ​



### [IState.cs]

~~~~c#
    /// <summary>
    /// State 역할.
    /// 상태를 나타내는 객체들이 구현할 interface.
    /// </summary>
    public interface IState
    {
        void InsertCoin(); //동전 투입.

        void EjectCoin(); //동전 반환.

        void TurnCrank(); //손잡이 돌림.

        void Dispense(); //뽑기물 내보냄.

        void Refill(); //뽑기 채워넣음.
    }
~~~~



### [NoCoinState.cs]

~~~~c#
    /// <summary>
    /// Concrete State
    /// 동전이 없는 상태를 나타내는 객체.
    /// </summary>
    public class NoCoinState : IState
    {
        private GumballMachine gumballMachine;

        /// <summary>
        /// 생성자를 통해서 뽑기기계 객체를 전달.
        /// </summary>
        /// <param name="gumballMachine"></param>
        public NoCoinState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        /// <summary>
        /// 현재 돈이 없는 상태이므로, 돈을 넣어주면 정상 투입 메시지를 출력하고
        /// 뽑기기계 상태를 NoCoin에서 -> HasCoin상태로 변경한다.
        /// </summary>
        public void InsertCoin()
        {
            Debug.Log("동전 투입하였다.");

            gumballMachine.SetState(gumballMachine.GetHasCoinState());
        }
        
        public void EjectCoin()
        {
            Debug.Log("동전을 넣지않아서 돌려줄게 없다.");
        }

        public void TurnCrank()
        {
            Debug.Log("손잡이를 돌렸지만, 동전이 없다.");
        }

        public void Dispense()
        {
            Debug.Log("동전이 없으니 먼저, 동전을 넣어라.");
        }

        public void Refill() { }
    }
~~~~



### [HasCoinState.cs]

~~~~c#
    /// <summary>
    /// Concrete State
    /// 동전이 투입된 상태를 나타내는 객체.
    /// </summary>
    public class HasCoinState : IState
    {
        private GumballMachine gumballMachine;

        public HasCoinState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void InsertCoin()
        {
            Debug.Log("동전을 또 넣을 수 없다.");
        }

        public void EjectCoin()
        {
            Debug.Log("동전 반환했다.");
        }

        /// <summary>
        /// 현재 돈이 투입된 상태이므로, 뽑기 손잡이를 돌리면 정상 메시지를 출력하고
        /// 뽑기기계 상태를 HasCoin -> Sold 상태로 변경한다.
        /// </summary>
        public void TurnCrank()
        {
            Debug.Log("뽑기 돌렸다.");
            gumballMachine.SetState(gumballMachine.GetSoldState());
        }

        public void Dispense()
        {
            Debug.Log("껌볼 주지마라.");
        }

        public void Refill()
        {
        }
    }
~~~~



### [SoldState.cs]

```c#
    /// <summary>
    /// Concrete State
    /// 뽑기가 정상적으로 나온 상태를 나타내는 객체.
    /// </summary>
    public class SoldState : IState
    {
        private GumballMachine gumballMachine;

        public SoldState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void InsertCoin()
        {
            Debug.Log("기다려요. 껌볼이 나오는 중입니다.");
        }

        public void EjectCoin()
        {
            Debug.Log("쏘리, 너는 이미 뽑기를 돌렸어");
        }

        public void TurnCrank()
        {
            Debug.Log("2번돌려도 껌 2개 안줘");
        }

        /// <summary>
        /// 뽑기기계가 정상작동한 상태이므로, 껌볼을 준다.
        /// 껌볼이 남았으면 Sold->NoCoin으로 / 매진됐으면 Sold->SoldOut상태로 변경한다.
        /// </summary>
        public void Dispense()
        {
            gumballMachine.ReleaseBall(); //껌볼나온다.

            if(gumballMachine.GetCount() > 0)
            {
                gumballMachine.SetState(gumballMachine.GetNoCoinState());
            }
            else
            {
                Debug.Log("웁스, 껌볼이 없다.");
                gumballMachine.SetState(gumballMachine.GetSoldOutState());
            }
        }

        public void Refill()
        {
        }
    }
```



### [SoldOutState.cs]

```c#
    /// <summary>
    /// Concrete State
    /// 뽑기가 매진된 상태를 나타내는 객체.
    /// </summary>
    public class SoldOutState : IState
    {
        private GumballMachine gumballMachine;

        public SoldOutState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void InsertCoin()
        {
            Debug.Log("동전을 넣을 수 없음. 기계가 매진됨.");
        }

        public void EjectCoin()
        {
            Debug.Log("동전 반환 안됨. 동전을 넣지않았음.");
        }

        public void TurnCrank()
        {
            Debug.Log("손잡이를 돌려도, 껌볼은 없다.");
        }

        public void Dispense()
        {
            Debug.Log("껌볼없으니 제공하지마라.");
        }

        /// <summary>
        /// 뽑기기계가 매진된 상태이므로, 해당 메소드 호출하면
        /// 뽑기를 다시 채워넣고, 기계 상태를 SoldOut->NoCoin 상태로 변경한다.
        /// </summary>
        public void Refill()
        {
            gumballMachine.SetState(gumballMachine.GetNoCoinState());
        }
    }
```



### [GumballMachine.cs]

```c#
    /// <summary>
    /// Context 객체.
    /// 현재 내부 상태를 가지고 있으며, 상태를 이용해 액션을 실행시킨다.
    /// </summary>
    public class GumballMachine
    {
        //미리 모든 상태 객체들을 생성해두고 삭제하지않고 사용하는 방식.
        //(상태 전환이 자주일어나는 경우에 유용)
        private IState soldOutState;
        private IState noCoinState;
        private IState hasCoinState;
        private IState soldState;

        private IState state;

        private int count = 0;

        public GumballMachine(int gumballCount)
        {
            soldOutState = new SoldOutState(this);
            noCoinState = new NoCoinState(this);
            hasCoinState = new HasCoinState(this);
            soldState = new SoldState(this);

            this.count = gumballCount;

            if(gumballCount > 0)
            {
                state = noCoinState;
            }
            else
            {
                state = soldOutState;
            }
        }

        //동전 삽입시.
        public void InsertQuarter()
        {
            state.InsertCoin();
        }

        //손잡이 돌릴때.
        public void TurnCrank()
        {
            state.TurnCrank();
            state.Dispense(); //껌볼 나올때
        }

        //동전 반환시 할일 (현재 예제에서는 사용하지않음).
        public void EjectQuarter()
        {
            state.EjectCoin();
        }

        public void ReleaseBall()
        {
            Debug.Log("껌볼이 굴러서 나온다...!");

            if(count > 0) {
                count = count - 1;
            }
        }

        public void Refill(int count)
        {
            this.count += count;
            Debug.Log("껌볼이 채워졌다. 현재 갯수 : " + this.count);
            state.Refill();
        }

        public void SetState(IState state)
        {
            this.state = state;
        }

        //Get 메서드.
        public int GetCount() { return count; }

        public IState GetState() { return state; }

        public IState GetSoldOutState() { return soldOutState; }
        public IState GetNoCoinState() { return noCoinState; }
        public IState GetHasCoinState() { return hasCoinState; }
        public IState GetSoldState() { return soldState; }
    }
```



### [MainProgram.cs]

```c#
    public class MainProgram : MonoBehaviour
    {
        void Main()
        {
            GumballMachine gumballMachine = new GumballMachine(2);

            Debug.Log("=================");

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Debug.Log("=================");

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Debug.Log("=================");

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Debug.Log("=================");

            gumballMachine.Refill(5);
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
        }
    }
```



---


### [실행 결과]

	=================
	동전 투입하였다.
	뽑기 돌렸다.
	껌볼이 굴러서 나온다...!
	=================
	동전 투입하였다.
	뽑기 돌렸다.
	껌볼이 굴러서 나온다...!
	웁스, 껌볼이 없다.
	=================
	동전을 넣을 수 없음. 기계가 매진됨.
	손잡이를 돌려도, 껌볼은 없다.
	껌볼없으니 제공하지마라.
	=================
	껌볼이 채워졌다. 현재 갯수 : 5
	동전 투입하였다.
	뽑기 돌렸다.
	껌볼이 굴러서 나온다...!



## 5. State 와 Strategy 패턴의 차이

- 기초가 되는 개념을 분리시켜 상황에 맞게 전략적으로 사용한다는 점이 동일한 점.



1. State 패턴

   - 클라이언트 개입없이 객체의 내부 상태에 따라서 자동으로 상태가 전환된다.

     ​

2. Strategy 패턴

   - 클라이언트가 어떤 객체를 사용할지 지정한다.




[참고]

http://jongyoungcha.tistory.com/entry/%EB%94%94%EC%9E%90%EC%9D%B8-%ED%8C%A8%ED%84%B4-state-%ED%8C%A8%ED%84%B4%EA%B3%BC-strategy-%ED%8C%A8%ED%84%B4%EC%97%90-%EB%8C%80%ED%95%B4