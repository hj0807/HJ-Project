# Bridge Pattern



## 1. Bridge Pattern 정의
- 구현 부분과 추상화 부분을 분리하여 서로 독립적으로 변형할 수 있게 하는 패턴

- 상속을 이용한 패턴으로 확장 설계에 용이

  ​

## 2. Bridge Pattern 의 사용 이유

- 인터페이스와 구현부가 서로 독립적인 구조를 가지면서 확장하기를 원할때 사용



## 3. 장/단점

### [장점]
- 인터페이스와 구현부가 완전 결합되는 것을 막을 수 있다.
- 인터페이스의 구현 방식을 캡슐화 가능

### [단점]
- 구조가 복잡해진다.



## 4. 코드 설명
- 무기의 종류는 총, 폭탄, 마력이 있고,
- 캐릭터 종류에는 솔져, 직스, 럭스 가 있다.

### [IWeapon.cs]

- 구체적인 기능을 구현하는 역할을 담당.

```c#
	public interface IWeapon
    {
        void Use();
    }
```

### [Bomb.cs]

```c#
    public class Bomb : IWeapon
    {
        public void Use()
        {
            Debug.Log("폭탄을 던진다");
        }
    }
```

### [Gun.cs]

```c#
    public class Gun : IWeapon
    {
        public void Use()
        {
            Debug.Log("총을 쏜다");
        }
    }
```

### [Spell.cs]

```c#
    public class Spell : IWeapon
    {
        public void Use()
        {
            Debug.Log("마법을 건다");
        }
    }
```

-----

### [Character.cs]

```c#
	public abstract class Character 
    {
        protected IWeapon weapon;

        // 캐릭터는 무기를 사용하는 것이기 때문에 
        // 무기에 대한 정보를 받는다.
        public Character(IWeapon weapon)
        {
            this.weapon = weapon;
        }

        public abstract void Attack();
    }
```

### [Soldier.cs]

```c#
    public class Soldier : Character
    {
        public Soldier(IWeapon weapon) : base(weapon)
        {
            this.weapon = weapon;
            Debug.Log("***총 쏘는 캐릭터 ***");
        }

        public override void Attack()
        {
            weapon.Use();
        }
    }
```

### [Jiggs.cs]

```c#
    public class Jiggs : Character
    {
        public Jiggs(IWeapon weapon) : base(weapon)
        {
            this.weapon = weapon;
            Debug.Log("*** 폭탄 던지는 캐릭터 ***");
        }

        public override void Attack()
        {
            weapon.Use();
        }
    }
```

### [Lux.cs]

```c#
    public class Lux : Character
    {
        public Lux(IWeapon weapon) : base(weapon)
        {
            this.weapon = weapon;
            Debug.Log("*** 마력을 부리는 캐릭터 ***");
        }

        public override void Attack()
        {
            weapon.Use();
        }
    }
```
---

### [MainProgram.cs]

```c#
    public class MainProgram : MonoBehaviour
    {
        void Start()
        {
            IWeapon gun = new Gun();
            IWeapon bomb = new Bomb();
            IWeapon spell = new Spell();

            Character cha = new Soldier(gun);
            cha.Attack();

            Character jiggs = new Jiggs(bomb);
            jiggs.Attack();

            Character lux = new Lux(spell);
            lux.Attack();
        }
    }
```

### [실행 결과]

	***총 쏘는 캐릭터 ***
	총을 쏜다
	*** 폭탄 던지는 캐릭터 ***
	폭탄을 던진다
	*** 마력을 부리는 캐릭터 ***
	마법을 건다
