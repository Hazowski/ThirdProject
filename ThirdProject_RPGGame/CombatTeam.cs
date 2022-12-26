using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ThirdProject_RPGGame
{
    public class CombatTeam : ICloneable
    {
        public string TeamName { get; set; }
        
        public List<CombatClass> CombatMember { get; set; }





        public CombatTeam(string teamName)
        {
            CombatMember = new List<CombatClass>();
            TeamName = teamName;
        }


        object ICloneable.Clone()
        {
            return new CombatTeam(TeamName);
        }

        public void AddToTeam(CombatClass teamMember)
        {

            CombatMember.Add(teamMember);
        }
        public int SummTeamPower()
        {
            int SummPower = 0;
            
            for (int i = 0; i < CombatMember.Count; i++)
            {                
                SummPower += CombatMember[i].PowerLevel();
            }
            return SummPower;                        
        }
        // metodę dającą dostęp(możliwość odczytu i modyfikacji) bohatera drużyny o podanym indeksie(może to być dociążony operator [])        
        
        public override string ToString()
        {
            string teamMembers = string.Empty;
            foreach (CombatClass member in CombatMember)
                teamMembers += Environment.NewLine + member.ToString();
            return $"Team name:{TeamName},Summary of team members power: {SummTeamPower()}, List of Team members: {teamMembers}"; 

     
        }
    }
}
