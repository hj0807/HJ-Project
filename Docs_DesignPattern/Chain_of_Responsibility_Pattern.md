# Chain of Responsibility Pattern (책임 연쇄) 



## 1. Chain of Responsibility Pattern정의 
- [행동 패턴]

- `요청을 하는 객체`(송신)와 요청을 받아 `처리(수신)하는 객체` 사이의 **결합을 줄이는 패턴**

- 요청을 받는 객체들을 연쇄적으로 묶는다 => 맨 첫 객체부터 처리할 객체에 도달할때까지 연쇄적으로 요청을 넘긴다 

- ex) 기획자가 프로그래머에게 파티클 버그를 수정해달라고 요청 -> 프로그래머가 이펙트 팀에게 버그를 전달함 -> 이펙트 팀이 해당 버그 수정.

  ​



## 2. UML Diagram
![uml](http://www.dofactory.com/images/diagrams/net/chain.gif)



## 3. 장/단점

### [장점]


- 시스템의 결합도를 낮춘다.
- 객체들을 연쇄적으로 묶는 것을 동적으로 처리 가능.




### [단점]

- 요청 결과가 제대로 처리될지 알 수 없다. 

  - 연쇄적으로 요청을 전달하였으나 처리할 객체가 존재하지 않을 경우 요청이 처리되지 X

  ​


## 4. 코드 설명

- 각 컴퓨터 부품(Monitor, Mouse, Keyboard)을 정의하고, 이 부품들을 사용하는 Computer 클래스를 정의
- Computer 클래스에서는 각 부품들을 인터페이스로 관리하여, 인터페이스에 정의된 Accept(Visitor) 메서드를 호출
- 각 Visitor 클래스에서 객체들을 전달받아 객체들에 대한 세부 작업을 구현하는 구현 클래스 역할을 함.



### [IComputerPart.cs]

~~~~c#
    /// <summary>
    /// Element 인터페이스 역할 (데이터의 인터페이스)
    /// 
    /// 각 객체는 Visitor 객체가 세부 작업을 처리할 수 있도록 
    /// Visitor 인터페이스를 받아야한다.
    /// </summary>
    public interface IComputerPart
    {
        void Accept(IComputerPartVisitor visitor);
    }
~~~~


### [Monitor.cs]

~~~~c#
    /// <summary>
    /// Concrete Element 역할 
    /// IComputerPart의 구현 클래스
    /// </summary>
    public class Monitor : IComputerPart
    {
        // Visitor에 자기 자신을 전달 (Visitor가 해당 객체의 세부작업을 처리할 수 있도록)
        public void Accept(IComputerPartVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
~~~~


### [Keyboard.cs]

~~~~c#
    /// <summary>
    /// Concrete Element 역할 
    /// IComputerPart의 구현 클래스
    /// </summary>
    public class Keyboard : IComputerPart
    {
        public void Accept(IComputerPartVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
~~~~


### [Mouse.cs]

```c#
    /// <summary>
    /// Concrete Element 역할 
    /// IComputerPart의 구현 클래스
    /// </summary>
    public class Mouse : IComputerPart
    {
        public void Accept(IComputerPartVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
```



### [Computer.cs]

```c#
    /// <summary>
    /// Concrete Element 역할
    /// IComputerPart의 구현 클래스
    /// 
    /// 복잡한 구조체 (부품들을 가지고 있음) - Composite 패턴과 유사.
    /// 이 구조체를 사용하고 싶을 때 Visitor를 통해서 내부 로직에 접근한다.
    /// </summary>
    public class Computer : IComputerPart
    {
        private IComputerPart[] parts;

        // 부품을 생성한다.
        public Computer()
        {
            parts = new IComputerPart[] { new Monitor(), new Keyboard(), new Mouse() };
        }

        public void Accept(IComputerPartVisitor visitor)
        {
            for(int i=0; i<parts.Length; i++) {
                parts[i].Accept(visitor);
            }
            visitor.Visit(this);
        }
    }
```



### [IComputerPartVisitor.cs]

```c#
    /// <summary>
    /// Visitor 인터페이스
    /// 객체들을 자신을 던져주는 Visit 메소드를 정의 
    /// (객체추가시 메소드도 추가되야된다)
    /// 
    /// 모든 객체들은 방문자를 통해 세부 구현을 해야하니까, 각 객체들의 방문자들을 총집합시키는 인터페이스?
    /// </summary>
    public interface IComputerPartVisitor
    {
        void Visit(Monitor monitor);
        void Visit(Keyboard keyboard);
        void Visit(Mouse mouse);
        void Visit(Computer computer);
    }
```

### [ComputerPartDisplayVisitor.cs]

```c#
    /// <summary>
    /// Concrete Visitor 역할
    /// Visitor 인터페이스를 구현
    /// 
    /// 각 객체들을 전달받아 클래스에서 세부 작업을 처리한다.
    /// 컴퓨터 부품들의 상태를 확인하는 클래스.
    /// </summary>
    public class ComputerPartDisplayVisitor : IComputerPartVisitor
    {
        public void Visit(Monitor monitor)
        {
            Debug.Log("모니터 상태를 보여준다.");
        }

        public void Visit(Keyboard keyboard)
        {
            Debug.Log("키보드 상태를  보여준다.");
        }

        public void Visit(Mouse mouse)
        {
            Debug.Log("마우스 상태를 보여준다.");
        }

        public void Visit(Computer computer)
        {
            Debug.Log("컴퓨터 상태를 보여준다.");
        }
    }
```

### [ComputerPartExecuteVisitor.cs]

```c#
    /// <summary>
    /// Concrete Visitor 역할
    /// Visitor 인터페이스를 구현
    /// 
    /// 각 객체들을 전달받아 클래스에서 세부 작업을 처리한다.
    /// 컴퓨터 부품들을 실행시키는 클래스.
    /// </summary>
    public class ComputerPartExecuteVisitor : IComputerPartVisitor
    {
        public void Visit(Monitor monitor)
        {
            Debug.Log("모니터를 작동한다.");
        }

        public void Visit(Keyboard keyboard)
        {
            Debug.Log("키보드를 작동한다.");
        }

        public void Visit(Mouse mouse)
        {
            Debug.Log("마우스를 작동한다.");
        }

        public void Visit(Computer computer)
        {
            Debug.Log("컴퓨터를 작동한다");
        }
    }
```



### [MainProgram.cs]

~~~~c#
    public class MainProgram : MonoBehaviour
    {
        void Start()
        {
            //복잡한 구조체를 정의해놓고,
            IComputerPart computer = new Computer();

            //Visitor를 전달하여 세부 기능을 실행.
            // Visitor 전달 -> Computer -> Visitor에 전달.
            computer.Accept(new ComputerPartDisplayVisitor());

            computer.Accept(new ComputerPartExecuteVisitor());
        }
    }
~~~~

---


### [실행 결과]

	모니터 상태를 보여준다.
	키보드 상태를  보여준다.
	마우스 상태를 보여준다.
	컴퓨터 상태를 보여준다.
	
	모니터를 작동한다.
	키보드를 작동한다.
	마우스를 작동한다.
	컴퓨터를 작동한다.
