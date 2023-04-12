using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class Form3 : Form
    {
        //set up the hint for user
        public Form3()
        {
            InitializeComponent();
            labelInformation.Text = "Please enter the information of a team as the format below, sepreate the informationb by one semicolon';' and one space' '";
            labelFormat.Text = "team's name; team's ground; team's coach; team's founded year; team's region; ";
            labelExampleInformation.Text = "There is an example below:";
            labelExample.Text = "Auckland; Eden Park; Tom McCartney; Founded 1883, Auckland";
        }
        //close the form
        private void buttonAddNewTeam_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /*
         GetData Function
         Method: return the entered text from textbox
         Return type: string
         */
        public string GetData()
        {
            return textBoxPlayerInfo.Text;
        }
    }
}
