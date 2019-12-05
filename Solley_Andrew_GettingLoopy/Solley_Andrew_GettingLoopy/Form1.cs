//Andrew Solley
//Period 8
//Getting Loopy
//9/21/16
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Solley_Andrew_GettingLoopy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ForBtn_Click(object sender, EventArgs e)
        {
            int numStop;                                                //creates a interaction box that makes a messagebox pop up the number of times you enter.
                numStop = int.Parse(Interaction.InputBox("Enter a Number"));
            for (int i = 1; i <= (numStop); i++) 
            {
                MessageBox.Show(i.ToString());
            }
       

        }

        private void WhileBtn_Click(object sender, EventArgs e)
        {
            string pw1 = "",  pw2 = "";                             //Creates a input box that makes you enter a password then makes you re-enter and checks if it is the same.
            pw1 = Interaction.InputBox("Enter Pasword");
            while (pw1 != pw2)
            {
                pw2 = Interaction.InputBox("Re-enter the password!");
            }

            MessageBox.Show("Password Correct!");

        }

        private void DoWhileBtn_Click(object sender, EventArgs e)
        {
            string input;                                           //creates an input box that only lets you close it if you enter text
            do
            {
                input = Interaction.InputBox("Enter any text you would like!");
            }
            while (input == "" );
            
        }

        private void ForEachBtn_Click(object sender, EventArgs e)
        {

            string sentence = Interaction.InputBox("");         //Creates an input box that tells you how many characters there is in your string.            
            int count = 0;
            foreach (char current in sentence) 
                count = count + 1;
            MessageBox.Show(count.ToString());
        }

    }
}
