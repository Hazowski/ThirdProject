namespace ThirdProject_RPGGame
{
    public class Warrior : CombatClass
    {
        public Warrior(string name = "Geralt", int healthPoints = 100) : base(name, healthPoints, 8)
        {
            Strenght = ThrowDice(2);
        }

        public override int PowerLevel()
        {
            if (HealthPoints <= 5) return Strenght;
            return Strenght * HealthPoints / 100;
        }

        public override string ToString()
        {
            return $"Warrior name: {Name}, HP: {HealthPoints}, Power: {PowerLevel()} ";
        }
    }

}
