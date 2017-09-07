# [생성 패턴] Factory Pattern 

<br />

## 1. Factory Pattern 정의
- 객체를 생성하기 위한 인터페이스를 정의, 어떤 클래스의 인스턴스를 만들지는 서브 클래스에서 결정
- 동일한 인터페이스를 준수하는 클래스들을 생성

<br />


http://codingcoding.tistory.com/324
http://codepump.tistory.com/26



















<br />
## 4. 장/단점

#### [장점]
- 객체를 생성하기 위한 별도의 객체 생성 클래스가 불필요
- 객체 생성을 캡슐화할 수 있다.

#### [단점]
- 생성될 객체들의 클래스들이 모두 Clone() 메소드를 구현해야한다.





-------------------------------------------------------------------


## 3. Prototype 의 사용 이유

- 종류가 너무 많아서 각 클래스로 정리할 수 없는 경우



<br />
## 5. 코드 설명

- 비슷한 속성을 가진 객체를 매번 각 클래스에서 처리하기에는 코드가 중복되는 문제점도 있고, 효율성이 떨어짐.
- 객체를 생성하기 위한 추상화 클래스(Enemy)를 정의해놓고, 이를 상속받은 서브 클래스(Slime, Boss)에서 각자 처리한다,





#### [IEmployee.cs]

~~~~
 public interface IEmployee
    {
        IEmployee Clone();
        string GetDetailInfo();
    }
~~~~
<br />

#### [Developer.cs]

~~~~
    public class Developer : IEmployee
    {
        public string Name { get; set; }
        public string Role { get; set; }
        public string langauge { get; set; }

        public IEmployee Clone()
        {
            return (IEmployee)MemberwiseClone();
        }

        public string GetDetailInfo()
        {
            return string.Format("Name : {0}, Role : {1}, langauge : {2}", Name, Role, langauge);
        }
    }
~~~~
<br />

#### [Designer.cs]

~~~~
    public class Designer : IEmployee
    {
        public string Name { get; set; }
        public string Role { get; set; }
        public string Tool { get; set; }

        public IEmployee Clone()
        {
            return (IEmployee)MemberwiseClone();
        }

        public string GetDetailInfo()
        {
            return string.Format("Name : {0}, Role : {1}, Tool : {2}", Name, Role, Tool);
        }
    }
~~~~
<br />

#### [MainProgram.cs]

~~~~
    public class MainProgram : MonoBehaviour
    {
        void Start()
        {
            Developer dev = new Developer();
            dev.Name = "Sam";
            dev.Role = "Team Leader";
            dev.langauge = "C++";

            Developer copyDev = dev.Clone() as Developer;
            copyDev.Name = "Jenny";
            copyDev.Role = "Programmer";

            Debug.Log(dev.GetDetailInfo());
            Debug.Log(copyDev.GetDetailInfo());

            Designer designer = new Designer();
            designer.Name = "Tom";
            designer.Role = "Designer ";
            designer.Tool = "PhotoShop";

            Designer copyDesigner = designer.Clone() as Designer;
            copyDesigner.Tool = "Grace";
            copyDesigner.Tool = "illust";

            Debug.Log(designer.GetDetailInfo());
            Debug.Log(copyDesigner.GetDetailInfo());
        }
    }
~~~~

<br />

#### [실행 결과]

	---------- Easy Map 몬스터 생성 ----------
	슬라임 등장 !! 
	슬라임 등장 !! 
	슬라임 등장 !! 
	보스 몬스터 등장 !!


	---------- Hard Map 몬스터 생성 ----------
	보스 몬스터 등장 !!
	보스 몬스터 등장 !!
	보스 몬스터 등장 !!
	슬라임 등장 !! 

<br />

## 6. 참고 사이트
- <http://codepump.tistory.com/26>















