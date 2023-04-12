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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        //close the form
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /*
         GetDataPlayer Function
         Method: return the entered text from textboxPlayer
         Return type: string
         */
        public string GetDataPlayer()
        {
            return textBoxSignPlayer.Text;
        }
        /*
         GetDataTeam Function
         Method: return the entered text from textboxTeam
         Return type: string
         */
        public string GetDataTeam()
        {
            return textBoxSignTeam.Text;
        }
    }
}
