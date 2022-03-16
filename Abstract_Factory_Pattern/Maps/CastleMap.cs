using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern.Maps
{
    class CastleMap : Map
    {
        public CastleMap()
        {
            Name = "Castle";
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing Castle Map...");
        }
    }
}
