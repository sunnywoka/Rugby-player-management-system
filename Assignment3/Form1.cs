using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Players;
using Teams;

/*
 <summary>
Author: Yuekai Wu 13113181
Date: 10/06/2020
This is an application to act as a player management. It allow user to read or write players' text file and teams' text file.It also can add new player and add new team
and sign a player to a team. User can easy get information of players' height and weight from chart and search players by their age and birth of place
*/
namespace Assignment3
{
    public partial class Form1 : Form
    {
        //declare players and teams
        Player[] players = new Player[100];
        Team[] teams = new Team[100];
        int teamNum = 0;
        int playerNum = 0;
        public Form1()
        {
            InitializeComponent();
            chartPlayerHeightWeight.Series.Clear();
            chartPlayerHeightWeight.Series.Add("Height");
            chartPlayerHeightWeight.Series.Add("Weight");


            chartPlayerAgeGroup.Series.Clear();
            chartPlayerAgeGroup.Series.Add("10-19");
            chartPlayerAgeGroup.Series.Add("20-29");
            chartPlayerAgeGroup.Series.Add("30-39");
            chartPlayerAgeGroup.Series.Add("40-49");
            chartPlayerAgeGroup.Series.Add("50-59");
            chartPlayerAgeGroup.Series.Add("60-69");

        }


        //User use menu strip to open a player file, the application will store the information of players, create the charts and list the information into the player
        //list
        private void listOfPlayersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (myOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                string type = myOpenFileDialog.ToString();
                string[] fileType = (type.Split('.'));
                if (fileType[4] != "txt")
                {
                    MessageBox.Show("It is not a txt file, please choose txt file", "Error");
                }
                using (FileStream fStream = File.OpenRead(myOpenFileDialog.FileName))
                {
                    StreamReader reader;
                    reader = new StreamReader(fStream);
                    string line;
                    while (reader.Peek() >= 0)
                    {
                        line = reader.ReadLine();
                        string[] pArray = (line.Split(';'));
                        players[playerNum] = new Player(pArray[0], pArray[1].Remove(0, 1), pArray[2].Remove(0, 1), pArray[3].Remove(0, 1), pArray[4].Remove(0, 1), pArray[5].Remove(0, 1), pArray[6].Remove(0, 1));
                        playerNum++;
                    }
                    reader.Close();
                    fStream.Close();
                }
                listViewPlayers.Items.Clear();
                var vPlayers = GetPlayersList();
                foreach (var p in vPlayers)
                {
                    var row = new string[] { p.id, p.firstName + p.lastName };
                    var lvi = new ListViewItem(row);
                    lvi.Tag = p;
                    listViewPlayers.Items.Add(lvi);
                }
                chartPlayerHeightWeight.Series.Clear();
                chartPlayerHeightWeight.Series.Add("Height");
                chartPlayerHeightWeight.Series.Add("Weight");
                for (int i = 0; i < playerNum; i++)
                {
                    DataPoint dp1 = new DataPoint();
                    dp1.SetValueXY(players[i].firstName, players[i].height);
                    chartPlayerHeightWeight.Series["Height"].Points.Add(dp1);

                    DataPoint dp2 = new DataPoint();
                    dp2.SetValueXY(players[i].firstName, players[i].weight);
                    chartPlayerHeightWeight.Series["Weight"].Points.Add(dp2);
                }

                chartPlayerAgeGroup.Series.Clear();
                chartPlayerAgeGroup.Series.Add("10-19");
                chartPlayerAgeGroup.Series.Add("20-29");
                chartPlayerAgeGroup.Series.Add("30-39");
                chartPlayerAgeGroup.Series.Add("40-49");
                chartPlayerAgeGroup.Series.Add("50-59");
                chartPlayerAgeGroup.Series.Add("60-69");

                int temp1 = 0, temp2 = 0, temp3 = 0, temp4 = 0, temp5 = 0, temp6 = 0;
                for (int i = 0; i < playerNum; i++)
                {
                    DataPoint dp = new DataPoint();
                    int numAge = Convert.ToInt32(players[i].GetAge());
                    
                    if ((10 <= numAge) && (numAge <= 19))
                    {
                        temp1++;
                        dp.SetValueXY("10-19", temp1);
                        chartPlayerAgeGroup.Series["10-19"].Points.Add(dp);
                    }
                    else if ((20 <= numAge) && (numAge <= 29))
                    {
                        temp2++;
                        dp.SetValueXY("20-29", temp2);
                        chartPlayerAgeGroup.Series["20-19"].Points.Add(dp);
                    }
                    else if ((30 <= numAge) && (numAge <= 39))
                    {
                        temp3++;
                        dp.SetValueXY("30-39", temp4);
                        chartPlayerAgeGroup.Series["30-39"].Points.Add(dp);
                    }
                    else if ((40 <= numAge) && (numAge <= 49))
                    {
                        temp4++;
                        dp.SetValueXY("40-49", temp4);
                        chartPlayerAgeGroup.Series["40-49"].Points.Add(dp);
                    }
                    else if ((50 <= numAge) && (numAge <= 59))
                    {
                        temp5++;
                        dp.SetValueXY("50-59", temp5);
                        chartPlayerAgeGroup.Series["50-59"].Points.Add(dp);
                    }
                    else if ((60 <= numAge) && (numAge <= 69))
                    {
                        temp6++;
                        dp.SetValueXY("60-69", temp6);
                        chartPlayerAgeGroup.Series["60-69"].Points.Add(dp);
                    }
                }

            }
        }

        /*
         GetPlayersList Function
         Method: return the List that store all players' information as typed collection structures
         Return type: List
         */
        public List<Player> GetPlayersList()
        {
            var list = new List<Player>();
            for (int i = 0; i < playerNum; i++)
            {
                list.Add(players[i]);
            }
            return list;
        }

        //User use menu strip to open a team file, the application will store the information of teamsand list the information into the team
        //list
        private void listOfTeamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (myOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                string type = myOpenFileDialog.ToString();
                string[] fileType = (type.Split('.'));
                if (fileType[4] != "txt")
                {
                    MessageBox.Show("It is not a txt file, please choose txt file", "Error");
                }
                using (FileStream fStream = File.OpenRead(myOpenFileDialog.FileName))
                {
                    StreamReader reader;
                    reader = new StreamReader(fStream);
                    string line;
                    while (reader.Peek() >= 0)
                    {
                        line = reader.ReadLine();
                        string[] tArray = (line.Split(';'));
                        string[] yArray = (tArray[3].Remove(0, 1).Split(','));
                        string[] yearArray = (yArray[0].Split(' '));
                        teams[teamNum] = new Team(tArray[0], tArray[1].Remove(0, 1), tArray[2].Remove(0, 1), yearArray[1], yArray[1].Remove(0, 1));
                        teamNum++;
                    }
                    reader.Close();
                    fStream.Close();
                }
                listViewTeams.Items.Clear();
                var vTeams = GetTeamsList();
                foreach (var t in vTeams)
                {
                    var row = new string[] { t.name };
                    var lvi = new ListViewItem(row);
                    lvi.Tag = t;
                    listViewTeams.Items.Add(lvi);
                }
            }
        }
        /*
         GetTeamsList Function
         Method: return the List that store all teams' information as typed collection structures
         Return type: List
         */
        public List<Team> GetTeamsList()
        {
            var list = new List<Team>();
            for (int i = 0; i < teamNum; i++)
            {
                list.Add(teams[i]);
            }
            return list;
        }

        //Save players' informatiom into a text file
        private void savePlayersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mySaveFileDialog.Filter = "Text File | *.txt";
            if (mySaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter myWriter = new StreamWriter(mySaveFileDialog.OpenFile());
                for (int i = 0; i < playerNum; i++)
                {
                    myWriter.WriteLine(players[i].id + "; " + players[i].firstName + "; " + players[i].lastName + "; " + players[i].birthday + "; " + players[i].height + "; " + players[i].weight + "; " + players[i].placeOfBirth);
                }
                myWriter.Close();
            }
        }

        //if user has problem with the application, they can real the user manual
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Find out more details in user manual", "Help");
        }

        //close the form
        private void FormPlayers_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Would you like to quit the program?", "Quit program", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                e.Cancel = true;
                MessageBox.Show("Cancel quiting the program");
            }
            else
            {
                MessageBox.Show("Program is closed");
            }
        }

        //Save the team information into a team text file
        private void saveTeamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mySaveFileDialog.Filter = "Text File | *.txt";
            if (mySaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter myWriter = new StreamWriter(mySaveFileDialog.OpenFile());
                for (int i = 0; i < teamNum; i++)
                {
                    myWriter.WriteLine(teams[i].name + "; " + teams[i].ground + "; " + teams[i].coach + "; Founded " + teams[i].foundedYear + ", " + teams[i].region);
                }
                myWriter.Close();
            }
        }

        //Click the button and move to other form to add a new player
        private void buttonAddNewPlayer_Click(object sender, EventArgs e)
        {
            Form2 myForm2 = new Form2();
            this.Visible = false;
            myForm2.ShowDialog();
            string line;
            line = myForm2.GetData();
            string[] pArray = (line.Split(';'));
            for (int i = 0; i < playerNum; i++)
            {
                if (pArray[0] == players[i].id)
                {
                    this.Visible = true;
                    MessageBox.Show("It is an duplicate player");
                    return;
                }
            }
            if (pArray.Length == 7)
            {
                players[playerNum] = new Player(pArray[0], pArray[1].Remove(0, 1), pArray[2], pArray[3].Remove(0, 1), pArray[4].Remove(0, 1), pArray[5].Remove(0, 1), pArray[6].Remove(0, 1));
                playerNum++;
                this.Visible = true;
                listViewPlayers.Items.Clear();
                var vPlayers = GetPlayersList();
                foreach (var p in vPlayers)
                {
                    var row = new string[] { p.id, p.firstName + p.lastName };
                    var lvi = new ListViewItem(row);
                    lvi.Tag = p;
                    listViewPlayers.Items.Add(lvi);
                }
            }
            else
            {
                this.Visible = true;
                MessageBox.Show("You entered player with wrong format, please check");
            }
            chartPlayerHeightWeight.Series.Clear();
            chartPlayerHeightWeight.Series.Add("Height");
            chartPlayerHeightWeight.Series.Add("Weight");
            for (int i = 0; i < playerNum; i++)
            {
                DataPoint dp1 = new DataPoint();
                dp1.SetValueXY(players[i].firstName, players[i].height);
                chartPlayerHeightWeight.Series["Height"].Points.Add(dp1);

                DataPoint dp2 = new DataPoint();
                dp2.SetValueXY(players[i].firstName, players[i].weight);
                chartPlayerHeightWeight.Series["Weight"].Points.Add(dp2);
            }

            chartPlayerAgeGroup.Series.Clear();
            chartPlayerAgeGroup.Series.Add("10-19");
            chartPlayerAgeGroup.Series.Add("20-29");
            chartPlayerAgeGroup.Series.Add("30-39");
            chartPlayerAgeGroup.Series.Add("40-49");
            chartPlayerAgeGroup.Series.Add("50-59");
            chartPlayerAgeGroup.Series.Add("60-69");
            for (int i = 0; i < playerNum; i++)
            {
                DataPoint dp = new DataPoint();
                int numAge = Convert.ToInt32(players[i].GetAge());
                int temp = 0;
                if ((10 <= numAge) && (numAge <= 19))
                {
                    temp++;
                    dp.SetValueXY("10-19", temp);
                    chartPlayerAgeGroup.Series["10-19"].Points.Add(dp);
                }
                else if ((20 <= numAge) && (numAge <= 29))
                {
                    temp++;
                    dp.SetValueXY("20-29", temp);
                    chartPlayerAgeGroup.Series["20-19"].Points.Add(dp);
                }
                else if ((30 <= numAge) && (numAge <= 39))
                {
                    temp++;
                    dp.SetValueXY("30-39", temp);
                    chartPlayerAgeGroup.Series["30-39"].Points.Add(dp);
                }
                else if ((40 <= numAge) && (numAge <= 49))
                {
                    temp++;
                    dp.SetValueXY("40-49", temp);
                    chartPlayerAgeGroup.Series["40-49"].Points.Add(dp);
                }
                else if ((50 <= numAge) && (numAge <= 59))
                {
                    temp++;
                    dp.SetValueXY("50-59", temp);
                    chartPlayerAgeGroup.Series["50-59"].Points.Add(dp);
                }
                else if ((60 <= numAge) && (numAge <= 69))
                {
                    temp++;
                    dp.SetValueXY("60-69", temp);
                    chartPlayerAgeGroup.Series["60-69"].Points.Add(dp);
                }
            }           
        }

        //Click the button and move to other form to add a new team
        private void buttonAddNewTeam_Click(object sender, EventArgs e)
        {
            Form3 myForm3 = new Form3();
            this.Visible = false;
            myForm3.ShowDialog();
            string line;
            line = myForm3.GetData();
            string[] tArray = (line.Split(';'));
            for (int i = 0; i < teamNum; i++)
            {
                if (tArray[0] == teams[i].name)
                {
                    this.Visible = true;
                    MessageBox.Show("It is an duplicate team");
                    return;
                }
            }
            if (tArray.Length == 4)
            {
                string[] yArray = (tArray[3].Remove(0, 1).Split(','));
                string[] yearArray = (yArray[0].Split(' '));
                teams[teamNum] = new Team(tArray[0], tArray[1].Remove(0, 1), tArray[2].Remove(0, 1), yearArray[1], yArray[1].Remove(0, 1));
                teamNum++;
                this.Visible = true;
                listViewTeams.Items.Clear();
                var vTeams = GetTeamsList();
                foreach (var t in vTeams)
                {
                    var row = new string[] { t.name };
                    var lvi = new ListViewItem(row);
                    lvi.Tag = t;
                    listViewTeams.Items.Add(lvi);
                }
            }
            else
            {
                this.Visible = true;
                MessageBox.Show("You entered team with wrong format, please check");
            }
        }

        //Search player by age
        private void buttonSearchAge_Click(object sender, EventArgs e)
        {
            int enterAge = (int)numericUpDownAge.Value;
            string output = "This is the list of player(s) matched searching age:\n";
            for(int i=0; i<playerNum; i++)
            {
                if (Convert.ToInt32(players[i].GetAge()) == enterAge)
                {
                    output += players[i].PrintPlayers();
                }
            }
            if(output== "This is the list of player(s) matched searching age:\n")
            {
                MessageBox.Show("There is no matched player");
            }
            else
            {
                MessageBox.Show(output);
            }
        }

        //search player by birth of place
        private void buttonBirthOfPlace_Click(object sender, EventArgs e)
        {
            
            if (int.TryParse(textBoxBirthOfPlace.Text, out int temp))
            {
                MessageBox.Show("Please enter a correct place");

            }
            else
            {
                string enterPlace = textBoxBirthOfPlace.Text + ", New Zealand";
                string output = "This is the list of player(s) matched searching birth of place:\n";
                for (int i = 0; i < playerNum; i++)
                {
                    if (players[i].placeOfBirth == enterPlace)
                    {
                        output += players[i].PrintPlayers();
                    }
                }
                if (output == "This is the list of player(s) matched searching birth of place:\n")
                {
                    MessageBox.Show("There is no matched player");
                }
                else
                {
                    MessageBox.Show(output);
                }
            }
        }

        //Click the button and move to other form to sign a player to a team
        private void buttonSignPlayer_Click(object sender, EventArgs e)
        {
            Form4 myForm4 = new Form4();
            this.Visible = false;
            myForm4.ShowDialog();
            string playerInfo = myForm4.GetDataPlayer();
            string teamInfo = myForm4.GetDataTeam();
            bool hasNoPlayer = true;
            bool hasNoTeam = true;
            for (int t = 0; t < teamNum; t++)
            {
                if (teamInfo == teams[t].name)
                {
                    for (int p = 0; p < playerNum; p++)
                    {
                        hasNoTeam = false;
                        if (playerInfo == players[p].PrintPlayersFullName())
                        {
                            hasNoPlayer = false;
                        }

                        if ((playerInfo == players[p].PrintPlayersFullName()) && (players[p].signedTeam == null))
                        {
                            players[p].signedTeam = teamInfo;
                            teams[t].signedPlayers = teams[t].signedPlayers + playerInfo + ", ";
                            MessageBox.Show("Successfully sign " + players[p].PrintPlayersFullName() + " to team " + teams[t].name);
                            hasNoPlayer = false;
                            break;
                        }
                        else if (players[p].signedTeam != null)
                        {
                            MessageBox.Show(players[p].PrintPlayersFullName() + " has signed  team " + players[p].signedTeam);
                            hasNoPlayer = false;  
                            this.Visible = true;
                            continue;
                        }
                    }
                    break;
                }
            }
            if (hasNoPlayer)
            {
                MessageBox.Show("There is no matched player");
            }
            if (hasNoTeam)
            {
                MessageBox.Show("There is no matched team");
            }
            this.Visible = true;
        }

        //Click the player in list and display his information
        private void listViewPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listViewPlayers.SelectedItems.Count > 0)
                {
                    var selectedItem = (Player)listViewPlayers.SelectedItems[0].Tag;
                    if(selectedItem != null)
                    {
                        MessageBox.Show(selectedItem.PrintPlayersDetail(), "Player details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Click the team in list and display its information
        private void listViewTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listViewTeams.SelectedItems.Count > 0)
                {
                    var selectedItem = (Team)listViewTeams.SelectedItems[0].Tag;
                    if (selectedItem != null)
                    {
                        MessageBox.Show(selectedItem.PrintTeamDetail(), "Team details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Save players information and their signed team in a text file
        private void savePlayersWTeamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mySaveFileDialog.Filter = "Text File | *.txt";
            if (mySaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter myWriter = new StreamWriter(mySaveFileDialog.OpenFile());
                for (int i = 0; i < playerNum; i++)
                {
                    myWriter.WriteLine(players[i].PrintPlayerWithTeam());
                }
                myWriter.Close();
            }
        }

        //Save teams information and theis signed players in a text file
        private void saveTeamsWithPlayersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mySaveFileDialog.Filter = "Text File | *.txt";
            if (mySaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter myWriter = new StreamWriter(mySaveFileDialog.OpenFile());
                for (int i = 0; i < teamNum; i++)
                {
                    myWriter.WriteLine(teams[i].PrintTeamWithPlayer());
                }
                myWriter.Close();
            }
        }
    }
}
