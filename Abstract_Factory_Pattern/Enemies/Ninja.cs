using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern.Enemies
{
    class Ninja : Enemy
    {
        public Ninja()
        {
            HealthPoints = 75;
        }

        public override void Spawn()
        {
            Console.WriteLine($"Ninja spawning with {HealthPoints} HP");
        }
    }

}
