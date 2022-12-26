using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdProject_RPGGame
{

    public class UpdateTeamMember
    {
        public UpdateTeamMember(string name, int healthPoints)
        {
            Name = name;
            HealthPoints = healthPoints;
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
        public UpdateMage(string name, int healthPoints, int magePoints) : base(name, healthPoints)
        {
            MagePoints = magePoints;
        } 
        

        public int MagePoints { get; }



    }
}
