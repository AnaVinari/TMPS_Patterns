using System;

namespace Abstract_Factory_Pattern.Enemies
{
    class VampireEnemy : Enemy
    {
        public VampireEnemy()
        {
            HealthPoints = 100;
        }

        public override void Spawn()
        {
            Console.WriteLine($"Vampire spawned on map with {HealthPoints} HP");
        }
    }
}
