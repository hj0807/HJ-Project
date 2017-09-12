﻿
namespace BridgePattern.ex1
{
    public  class Abstraction
    {
        protected Implementor implementor;

        public Implementor Implementor
        {
            set
            {
                implementor = value;
            }
        }

        public virtual void Operation()
        {
            implementor.Operation();
        }
    }

}