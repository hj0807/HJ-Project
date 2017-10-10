
namespace FactoryMethodPattern.ex2
{
    public class HardMapGenerator : EnemyGenerator
    {
        public override void CreateEnemys()
        {
            enemyList.Add(new Boss());
            enemyList.Add(new Boss());
            enemyList.Add(new Boss());
            enemyList.Add(new Slime());
        }
    }
}
