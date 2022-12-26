namespace ThirdProject_RPGGame
{
    internal class Mage : CombatClass
    {
        protected int MagePoints { get; set; }

        public Mage(string name = "Geralt", int healthPoints = 100, int magePoints = 5) : base(name, healthPoints, 8)
        {
            Strenght = ThrowDice(1);
            MagePoints = ThrowDice(2);

        }
        public override int PowerLevel()
        {
            return (Strenght + MagePoints) * HealthPoints / 100;
        }
        
        public int GetMagePoints() => MagePoints;

        public override void UpdateTeamMember(UpdateTeamMember update)
        {
            base.UpdateTeamMember(update);
            MagePoints = (update as UpdateMage).MagePoints;
        }

        public override string ToString()
        {
            return $"Mage name: {Name}, HP: {HealthPoints}, Power: {PowerLevel()} ";
        }
    }




}
