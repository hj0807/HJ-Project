using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BridgePattern.ex3
{
    public interface IWeapon
    {
        void Use();
    }

    public class Bomb : IWeapon
    {
        public void Use()
        {
            Debug.Log("폭탄을 던진다");
        }
    }

    public class Gun : IWeapon
    {
        public void Use()
        {
            Debug.Log("총을 쏜다");
        }
    }

    public class Spell : IWeapon
    {
        public void Use()
        {
            Debug.Log("마법을 건다");
        }
    }

}