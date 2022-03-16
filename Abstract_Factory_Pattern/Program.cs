using Abstract_Factory_Pattern.Enemies;
using Abstract_Factory_Pattern.Maps;
using Abstract_Factory_Pattern.Factories;

namespace Abstract_Factory_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ILevelFactory factory = new Level1Factory();

            Enemy enemy = factory.CreateEnemy();
            Map map = factory.CreateMap();

            map.Draw();
            enemy.Spawn();
        }
    }

}