using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PrototypePattern
{
    public class ConcreatePrototypeA : Cloneable
    {
        public ConcreatePrototypeA(string id) : base(id)
        {
        }

        public override Cloneable Clone()
        {
            return (Cloneable)this.MemberwiseClone();
        }
    }
}

