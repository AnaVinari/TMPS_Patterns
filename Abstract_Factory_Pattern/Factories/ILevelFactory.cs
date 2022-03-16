using Abstract_Factory_Pattern.Enemies;
using Abstract_Factory_Pattern.Maps;


namespace Abstract_Factory_Pattern.Factories
{
    interface ILevelFactory
    {
        Map CreateMap();
        Enemy CreateEnemy();
    }
}
