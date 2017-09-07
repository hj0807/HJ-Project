using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PrototypePattern
{
    public class ConcreatePrototypeB : Cloneable
    {
        public ConcreatePrototypeB(string id) : base(id)
        {
        }

        public override Cloneable Clone()
        {
            return (Cloneable)this.MemberwiseClone();
        }
    }
}


