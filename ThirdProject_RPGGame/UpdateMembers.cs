namespace ThirdProject_RPGGame
{

    public class UpdateTeamMember
    {
        public UpdateTeamMember(string name, int healthPoints)
        {
            Name = name;
            HealthPoints = healthPoints;
        }
        public UpdateTeamMember(string name)
        {
            Name = name;
        }

        public string Name { get; }
        public int HealthPoints { get; }
    }

    public class UpdateWarrior : UpdateTeamMember
    {
        public UpdateWarrior(string name, int healthPoints) : base(name, healthPoints) { }


    }

    public class UpdateMage : UpdateTeamMember
    {
        public int MagePoints { get; }
        public UpdateMage(string name, int healthPoints, int magePoints) : base(name, healthPoints)
        {
            MagePoints = magePoints;
        }


        



    }
}
