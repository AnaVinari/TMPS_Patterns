using Abstract_Factory_Pattern.Enemies;
using Abstract_Factory_Pattern.Maps;


namespace Abstract_Factory_Pattern.Factories
{
    class Level1Factory : ILevelFactory
    {
        public Enemy CreateEnemy()
        {
            return new VampireEnemy();
        }

        public Map CreateMap()
        {
            return new CastleMap();
        }
    }
}
