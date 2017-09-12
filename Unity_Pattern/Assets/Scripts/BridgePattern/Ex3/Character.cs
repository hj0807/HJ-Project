using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BridgePattern.ex3
{
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
}