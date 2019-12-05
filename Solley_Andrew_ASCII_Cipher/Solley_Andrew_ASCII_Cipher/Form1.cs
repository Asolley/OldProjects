//ASCII Cipher
//10/12/16
//Period 8
//Andrew Solley
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solley_Andrew_ASCII_Cipher
{
    public partial class Form1 : Form
    {
        int intShift = 3;                                                   //creates an integer that have the value of 3
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            string decodedString = txtDecoded.Text;                         //declares a string that is equal to the text of the decoded textbox.
            string encodedString = "";                                      //declares a string that displays nothing.

            for (int i = 0; i <= decodedString.Length - 1; i++)             //creates a for loop that loops through each char in decoded string
            {
                char thisChar = decodedString[i];                           //declares a char that is equal to the decode string in int
                int encodedValue = (int)thisChar + intShift;                //delcares an int that takes thischar and adds 3 to it
                if (encodedValue == 125)                                    //creates and if statemenet that changes the integer value of z to c
                {
                    encodedValue = 99;
                }
                if (encodedValue == 124)                                    //creates and if statemenet that changes the integer value of y to b
                {
                    encodedValue = 98;
                }
                if (encodedValue == 123)                                    //creates and if statemenet that changes the integer value of  x to a
                {
                    encodedValue = 97;                          
                }
                encodedString += (char)encodedValue;                        //makes encodedstring text add the encodedvalue in char form
            }
            txtEncoded.Text = encodedString;                                //makes the text of txtencoded equal encodedstring
        }
        private void btnDecode_Click_1(object sender, EventArgs e)
        {
            {
                string encodedString = txtEncoded.Text;                     //declares a string that equals the text of txtencoded
                string decodedString = "";                                  //declares a string that displays nothing

                for (int i = 0; i <= encodedString.Length - 1; i++)         //creates a for loop that loops through each character in encodedstring
                {
                    char thisChar = encodedString[i];                       //declares a char that equals the integer value of encodedstring
                    int decodeValue = (int)thisChar - intShift;             //declares a int that equals the integer value of thischar and subtracts intshift
                    if (decodeValue == 96)                                  //creates an if statement that changes the integer value of c to z
                    {
                        decodeValue = 122;
                    }
                    if (decodeValue == 95)                                  //creates an if statement that changes the integer value of b to y
                    {
                        decodeValue = 121;
                    }
                    if (decodeValue == 94)                                  //creates an if statment that changes the integer value of a to x
                    {
                        decodeValue = 120;
                    }
                    decodedString += (char)decodeValue;                     //makes the text of decodedstring add decodedvalue in char form
                }
                txtDecoded.Text = decodedString;                            //makes the text of txt decoded equal the text of decodestring
            }
        }
    }
}
