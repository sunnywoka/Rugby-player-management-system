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
    public partial class Form2 : Form
    {
        //set up the hint for user
        public Form2()
        {
            InitializeComponent();
            labelInformation.Text = "Please enter the information of a player as the format below, sepreate the informationb by one semicolon';' and one space' '";
            labelFormat.Text = "player's ID; player's firstname; player's lastname; player's birthday; player's height; player's weight; player's place of birth";
            labelExampleInformation.Text = "There is an example below:";
            labelExample.Text = "1; Richard; McCaw; 31/12/1980; 187; 107; Oamaru, New Zealand";
        }
        //close the form
        private void buttonBackMainPage_Click(object sender, EventArgs e)
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
