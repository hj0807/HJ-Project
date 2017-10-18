using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlyweightPattern.ex2
{
    public class CoffeeOrderContext
    {
        private int tableNumber;

        public CoffeeOrderContext(int tableNumber)
        {
            this.tableNumber = tableNumber;
        }

        public int GetTableNumber()
        {
            return tableNumber;
        }
    }
}