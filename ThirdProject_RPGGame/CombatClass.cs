namespace ThirdProject_RPGGame
{
    public abstract class CombatClass
    {
        protected string Name { get; set; }
        protected int HealthPoints { get; set; }
        protected int Strenght { get; set; }

        public CombatClass(string name, int healthPoints, int strenght)
        {
            Name = name;
            HealthPoints = healthPoints;
            Strenght = strenght;
        }

        public int AddOrDeductHp(int hp)
        {
            if (HealthPoints + hp < 0) return 0;
            else if (HealthPoints + hp > 100) return 100;
            return HealthPoints + hp;
        }

        public abstract int PowerLevel();
        public string GetName() => Name;
        public int GetHealthPoints() => HealthPoints;



        public virtual void UpdateTeamMember(UpdateTeamMember update)
        {
            Name = update.Name;
            HealthPoints = update.HealthPoints;
        }


        public int ThrowDice(int throwNumber)
        {
            Random r = new Random();
            int summrInt = 0;
            for (int i = 0; i < throwNumber; i++)
            {
                summrInt += r.Next(1, 7);
            }
            return summrInt;
        }



    }
}
