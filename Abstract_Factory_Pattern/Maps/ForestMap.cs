using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern.Maps
{
    class ForestMap : Map
    {
        public ForestMap()
        {
            Name = "Forest";
        }
        public override void Draw()
        {
            Console.WriteLine("Drawing Forest Map...");
        }
    }
}
