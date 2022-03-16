namespace Abstract_Factory_Pattern.Enemies
{
    abstract class Enemy
    {
        public int HealthPoints { get; set; }

        public abstract void Spawn();
    }
}
