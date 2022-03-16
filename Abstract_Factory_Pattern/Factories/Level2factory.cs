using Abstract_Factory_Pattern.Enemies;
using Abstract_Factory_Pattern.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern.Factories
{
    class Level2Factory : ILevelFactory
    {
        public Enemy CreateEnemy()
        {
            return new Ninja();
        }

        public Map CreateMap()
        {
            return new ForestMap();
        }
    }
}
