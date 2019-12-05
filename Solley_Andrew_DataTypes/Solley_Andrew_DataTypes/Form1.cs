//Andrew Solley
//Period 8
//8/29/16
//Data Types and Variables
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solley_Andrew_DataTypes
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
        private void button1_Click(object sender, EventArgs e)
        {
            int myInt = 1;                                      //creates a integer named myInt with the value "1"
           dataValue.Text = myInt.ToString();                   //makes the dataValue labels display the integers value
            dataType.Text = "Int";                              //makes the dataType labels display "Int"
                }
        private void btndouble_Click(object sender, EventArgs e)
        {
            double myDouble = 1.11;                             //Created a double named myDouble with the value "1.11" 
            dataValue.Text = myDouble.ToString();               //Makes the dataValue dispaly the doubles value
            dataType.Text = "Double";                           //Makes the dataType display "Double"
        }
        private void btnChar_Click(object sender, EventArgs e)
        {
            char myChar = 'A';                                  //Creates a char named myChar with the value "A"
            dataValue.Text = myChar.ToString();                 //Makes the dataValue label display the value of myChar
            dataType.Text = "Char";                             //Makes the dataType label display "Char"
        }
        private void btnString_Click(object sender, EventArgs e)
        {
            string myString = "Hello";                          //Creates a string named myString with the value "Hello"
            dataValue.Text = myString;                          //Makes the dataValue label display the value of myString
            dataType.Text = "String";                           //Makes the dataType lable display "String"
        }
        private void btnBool_Click(object sender, EventArgs e)
        {
            bool myBool = true;                                 //Creates a bool named myBool with the value "True"
            dataValue.Text = myBool.ToString();                 //Makes the dataValue lable display the value of myBool
            dataType.Text = "Bool";                             //Makes he dataType label display "Bool"
        }
    }
}
