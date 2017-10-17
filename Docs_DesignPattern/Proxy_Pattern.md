# Proxy Pattern (프록시 패턴) 



## 1. Proxy Pattern 
- [구조 패턴]

- **대리자**로써 일을 맡기면 그 일을 처리하고 완료되면 결과를 알려주는 패턴.

- 객체에 대한 접근을 제어하기 위한 용도.

- 실제 사용하려는 객체를 대신하는 역할을 해주는 패턴.

  ​

```
[프록시 패턴 종류]

1) Virtual Proxy

- 객체 생성에 많은 비용이 발생하는 경우, 실제 사용할 때 객체가 생성되도록 대리자를 두어 접근을 제어한다.

2) Remote Proxy

- 원격객체에 대한 로컬 대리자 역할을 한다.
- 소켓 통신을 통하여 원격객체에 데이터를 얻거나 메소드를 호출할 경우 대리자를 통해 호출이 이뤄짐

3) Protection Proxy

- 접근제어가 필요한 객체에 대한 접근을 통제하고 Proxy 객체를 통해 접근가능한 정도만 노출시킬때 사용

4) Smart Reference

- 실제객체에 접근시 부가적인 기능을 수행하고자 할 때 사용
```



## 2. UML Diagram

![uml](https://upload.wikimedia.org/wikipedia/commons/thumb/7/75/Proxy_pattern_diagram.svg/439px-Proxy_pattern_diagram.svg.png)



- Proxy 
  - Real Subject를 참조하고 있으며, 클라이언트가 메소드 호출을 하면 프록시는 적절한 행동을 취한다.
  - 실제 객체에 액세스할 수 있도록하는 참조를 유지 관리.
- Subject 
  -  Real Subject와 Proxy에 대한 공용 인터페이스를 정의.
- Real Subject 
  -  Proxy가 나타내는 실제 객체를 정의.



## 3. 장/단점

### [장점]

- 클래스 내 처리과정이 복잡하거나 리소스를 많이 차지할 경우 사용할 수 있다. (메모리 자원 절약)



### [단점]

- 객체를 생성시 프록시를 한번 거치게 되므로, 빈번한 객체 생성시 성능이 저하될 수 있다.

​

## 4. 코드 설명

- 아래 예는 가상 프록시(Virtual Proxy) 패턴의 대표적인 예제.
- 이미지를 로드하고 보여주는 실제 객체(RealImage)가 있고, Proxy(ProxyImage)를 통해 실제 사용할 때 객체가 생성되도록 대리자를 두어 접근을 제어한다.





### [IImage.cs]

~~~~c#
    /// <summary>
    /// Subject 역할.
    /// Real Subject와 Proxy에 대한 공용 인터페이스를 정의.
    /// </summary>
    public interface IImage 
    {
        void DisplayImage();
    }
~~~~



### [RealImage.cs]

~~~~c#
    /// <summary>
    /// Real Subject 역할.
    /// Proxy가 나타내는 실제 객체를 정의.
    /// </summary>
    public class RealImage : IImage
    {
        private string fileName;

        public RealImage(string fileName)
        {
            this.fileName = fileName;

            LoadImageFromDisk();
        }

        //디스크에서 이미지를 로드한다.
        private void LoadImageFromDisk()
        {
            Debug.Log("Loading Image... " + fileName);
        }

        //이미지를 보여준다.
        public void DisplayImage()
        {
            Debug.Log("Display Image... " + fileName);
        }
    }
~~~~



### [ProxyImage.cs]

~~~~c#
    /// <summary>
    /// Proxy 역할.
    /// Real Subject를 참조하고 있으며, 클라이언트가 메소드 호출을 하면 프록시는 적절한 행동을 취한다.
    /// 실제 객체에 액세스할 수 있도록하는 참조를 유지 관리.
    /// </summary>
    public class ProxyImage : IImage
    {
        //실제 객체를 참조한다.
        private RealImage image;

        private string fileName;

        /// <summary>
        /// 생성자를 통해 파일명을 전달받는다.
        /// 실제 객체 생성시 필요.
        /// </summary>
        /// <param name="fileName"></param>
        public ProxyImage(string fileName)
        {
            this.fileName = fileName;
        }

        public void DisplayImage()
        {
            //객체의 생성은 1번만 하도록하고, 이후는 재사용하도록.
            if (image == null)
                image = new RealImage(fileName);

            image.DisplayImage();
        }
    }
~~~~



### [MainProgram.cs]

```c#
    public class MainProgram : MonoBehaviour
    {
        void Main()
        {
            //프록시 객체 생성.

            //프록시 객체만 생성해놓는것일뿐 RealImage 객체가 생성되는 것은 X.
            IImage image1 = new ProxyImage("Photo1"); 
            IImage image2 = new ProxyImage("Photo2");

            //여기부분에서 실제 RealImage 객체가 생성됨.(실제 사용시 생성)
            image1.DisplayImage(); //로딩 필요.(처음 1회)
            image1.DisplayImage();

            image2.DisplayImage(); //로딩 필요.(처음 1회)
            image2.DisplayImage();

            image1.DisplayImage();
        }
    }
```



---


### [실행 결과]

	Loading Image... Photo1
	Display Image... Photo1
	Display Image... Photo1
	
	Loading Image... Photo2
	Display Image... Photo2
	Display Image... Photo2
	
	Display Image... Photo1

