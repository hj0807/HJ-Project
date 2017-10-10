using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FactoryMethodPattern.ex2
{
    public abstract class EnemyGenerator
    {
        protected List<Enemy> enemyList = new List<Enemy>();

        // Factory Method.
        public abstract void CreateEnemys();
    }
}
