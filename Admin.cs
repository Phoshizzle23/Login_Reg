using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Reg
{
    public partial class Admin : Form
    {
        /*
         * This code is for the Admin form.
         * It is used for the Administrators to generate the user list.
         * The following is a breakdown of the code:
         * Home button - when clicked it will navigate to the login form.
         * button1 - when clicked the user list will be generated from the accounts.txt file in textBox1.
         * button2 - when clicked will clear the user list from textBox1.
         * button3 - when clicked it will exit the application with a 2 second delay.
         */
        public Admin()
        {
            InitializeComponent();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e) //Generate User List
        {
            //file path to access the user accounts text file
            string filePath = "accounts.txt"; //file path to access the user accounts text file

            //Read all lines from the file and join them into a single string with newline characters
            string fileContents = string.Join(Environment.NewLine, File.ReadAllLines(filePath));

            //Set the text box text to display the contents of the file
            textBox1.Text = fileContents;

        }

        private void button2_Click(object sender, EventArgs e) 
        {
            //Clear user list
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e) //Exit Button Method
        {
            //Exit and wait 2 seconds before closing the form
            System.Threading.Thread.Sleep(2000);
            Environment.Exit(0);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Adds vertical scroll bars to textBox1
            textBox1.ScrollBars = ScrollBars.Vertical;
        }
    }
}
