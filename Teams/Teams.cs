using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teams
{
    //Team class field
    public class Team
    {
        public string name;
        public string ground;
        public string coach;
        public string foundedYear;
        public string region;
        public string signedPlayers;

        //Team class constructor
        public Team(string myName, string myGround, string myCoach, string myFoundedYear, string myRegion)
        {
            name = myName;
            ground = myGround;
            coach = myCoach;
            foundedYear = myFoundedYear;
            region = myRegion;
        }

        /*
         PrintTeamDetail Function
         Method: return the details of teams with its signed player
         Return type: string
         */

        public string PrintTeamDetail()
        {

            return "Team name: " + name + "\nTeam ground: " + ground + "\nTeam Coach: " + coach + "\nTeam founded year: " + foundedYear
                + "\nTeam region: " + region + "\nTeam signed player(s): " + signedPlayers;
        }
        /*
         PrintTeamWithPlayer Function
         Method: return the details of teams, it is for writing the new text file
         Return type: string
         */
        public string PrintTeamWithPlayer()
        {
            return name + "; " + ground + "; " + coach + "; " + foundedYear + "; " + region + "; " + signedPlayers;
        }
    }
}
