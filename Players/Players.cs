using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Players
{
    //Player class field
    public class Player
    {
        public string id;
        public string firstName;
        public string lastName;
        public string birthday;
        public string height;
        public string weight;
        public string placeOfBirth;
        public string signedTeam;
        public string age;

        //player class constructor
        public Player(string myID, string myFirstName, string myLastName, string myBirthday, string myHeight, string myWeight, string myPlaceOfBirth)
        {
            id = myID;
            firstName = myFirstName;
            lastName = myLastName;
            birthday = myBirthday;
            height = myHeight;
            weight = myWeight;
            placeOfBirth = myPlaceOfBirth;
        }

        /*
         GetAge Function
         Method: return age of player by using this year subtract their birth year
         Return type: string
         */
        public string GetAge()
        {
            string[] yArray = birthday.Split('/');
            string year = yArray[2];
            int intAge = DateTime.Now.Year - Convert.ToInt32(year);
            age = intAge.ToString();
            return age;
        }
        /*
         PrintPlayers Function
         Method: return the name of players with next line
         Return type: string
         */
        public string PrintPlayers()
        {
            return firstName + " " + lastName +"\n";
        }
        /*
         PrintPlayersFullName Function
         Method: return the name of players
         Return type: string
         */
        public string PrintPlayersFullName()
        {
            return firstName + " " +lastName;
        }
        /*
         PrintPlayersDetail Function
         Method: return the details of players
         Return type: string
         */
        public string PrintPlayersDetail()
        {
            return "Player ID: " + id + "\nPlayer name: " + firstName + " " + lastName + "\nPlayer age: " + GetAge() + "\nPlayer birthday: " + birthday + "\nPlayer height: " +
                height + "cm\nPlayer weight: " + weight + "KG\nPlayer's place of birth: " + placeOfBirth + "\nPlayer signed team: " + signedTeam;
        }
        /*
         PrintPlayerWithTeam Function
         Method: return the details of players, it is for writing in a new file
         Return type: string
         */
        public string PrintPlayerWithTeam()
        {
            return id+"; "+firstName+"; "+lastName+"; "+birthday+"; "+height+"; "+weight+"; " + placeOfBirth + "; " + signedTeam;
        }
    }
}
