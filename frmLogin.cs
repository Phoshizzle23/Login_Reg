using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Login_Reg
{
    public partial class frmLogin : Form
    {
        /*
         * This code is for a basic login form with functionality to check the user's credentials and allow them to access the main dashboard. 
         * The following is a breakdown of the code:
         * button1 - method is called when the user clicks on the "Log in" button.
         * It reads in the username and password entered by the user, and checks them against a list of usernames and passwords stored in a text file called "accounts.txt".
         * If the username and password are found in the text file, a message box is displayed saying "Login successful!" and the dashboard form is displayed.
         * If the username and password are not found, a message box is displayed saying "Invalid username or password."
         * button2 - method is called when the user clicks on the "Clear" button.
         * It clears the username and password fields, and sets the focus back to the username field.
         * The checkbxShowPas - method is called when the user checks or unchecks the "Show Password" checkbox.
         * If the checkbox is checked, it sets the password character to \0, which makes the password visible.
         * If the checkbox is unchecked, it sets the password character to *, which hides the password.
         * label6 - method is called when the user clicks on the "Create Account" link.
         * It displays a new form called frmRegister and hides the login form.
         * button3 - when clicked it will exit the application with a 2 second delay.
         */
        public frmLogin()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e) //Log in Button Method
        {
            //Get username & password from text boxes
            string username = txtusername.Text;
            string password = txtpassword.Text;

            //Set file path for the accounts.txt file where the user information will be retrieved from
            string filePath = "accounts.txt";
            //Reads all lines of the file and stores each line as an element of an array of strings
            string[] lines = File.ReadAllLines(filePath);

            //Iterates through each line in the array of strings, which contains the user account information
            foreach (string line in lines) 
            {
                //Splits each line into an array of strings using the comma character as a separator
                string[] parts = line.Split(',');
                if (parts[0] == username && parts[1] == password)
                {
                    MessageBox.Show("Login successful!"); //Show a message box to indicate a successful login
                    dashboard dashboardForm = new dashboard(); //Create a new instance of the dashboard form
                    dashboardForm.Show(); //Display the dashboard form
                    this.Hide(); //Hide the login form
                    return; //Exit the method once login is successful
                }

            }
            //If the username or password is incorrect - show error message
            MessageBox.Show("Invalid username or password.");
        }

        private void button2_Click(object sender, EventArgs e) //Clear button Method
        {
            txtusername.Text = ""; //Clears the username field
            txtpassword.Text = ""; //Clears the password field
            txtusername.Focus(); //Set the curser back to username field
        }

        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e) //Show Password checkbox Method
        {
            if (checkbxShowPas.Checked) //If checkbox is checked - show password
            {
                txtpassword.PasswordChar = '\0';
            }
            else //If the checkbox isn't checked - keep password hidden
            {
                txtpassword.PasswordChar = '*';
            }
        }

        private void label6_Click(object sender, EventArgs e) //Create account option Method
        {
            new frmRegister().Show(); //Display register form
            this.Hide(); //Hide the login form
        }

        private void button3_Click(object sender, EventArgs e) //Exit Button Method
        {
            //Exit and wait 2 seconds before closing the form
            System.Threading.Thread.Sleep(2000);
            Environment.Exit(0);
        }
    }
}
