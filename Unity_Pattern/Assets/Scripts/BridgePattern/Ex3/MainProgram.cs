using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BridgePattern.ex3
{
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
}
