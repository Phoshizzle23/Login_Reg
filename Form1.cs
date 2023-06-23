using System;
using System.Data.OleDb;

namespace Login_Reg
{
    public partial class frmRegister : Form
    {
        /*
         * This code is for the registration form.
         * The following is a breakdown of the code:
         * button1 - method is executed when the "Register" button is clicked.
         * It retrieves the username and password entered by the user, appends it to an accounts.txt file along with a comma - shows a message box to indicate that the registration was successful.
         * If any error occurs while registering, the error message is shown in a message box and the LogError method is called to log the error to the error.log file.
         * LogError method logs the error messages to the error.log file.
         * checkbxShowPas - method is executed when the "Show Password" checkbox is checked or unchecked.
         * It shows or hides the password characters based on the state of the checkbox.
         * button2_Click method is executed when the "Clear" button is clicked.
         * It clears the text boxes and sets the cursor back to the username text box.
         * label6_Click method is executed when the "Already have an account? Log in" label is clicked.
         * It opens a new instance of the login form and closes the current registration form.
         * button3_Click method is executed when the "Generate Password" button is clicked.
         * It generates a random password consisting of uppercase and lowercase letters, numbers & special characters, then sets the password fields to the generated password.
         * button4 - method when clicked it will exit the application with a 2 second delay. 
         */
        public frmRegister()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e) //Register button Method
        {
            //Get username & password from text boxes
            string username = txtusername.Text;
            string password = txtpassword.Text;

            //Set file path for the accounts.txt file where the user information will be stored
            string filePath = "accounts.txt";
            //Combine the username and password into a single string with a comma separator
            string userInformation = $"{username},{password}";

            try
            {
                //Open accounts.txt file for writing and add the user information to the end of the file
                using (StreamWriter sw = File.AppendText(filePath))
                {
                    sw.WriteLine("\n" + userInformation);
                }
                //Show a message box to indicate that the registration was successful
                MessageBox.Show("Registration successful!");
            }
            catch (Exception ex)
            {
                //If an error occurs - show error message box and log the error
                string errorMessage = ($"An error occurred while registering: {ex.Message}");
                MessageBox.Show(errorMessage);

                //Log error to file
                LogError(errorMessage);
            }
        }
        private void LogError(string errorMessage) //This method logs errors to file
        {
            string logFilePath = "error.log";

            try
            {
                //Open error.log file for writing and append the error message along with current date\time
                using (StreamWriter sw = File.AppendText(logFilePath))
                {
                    sw.WriteLine(DateTime.Now.ToString() + " - " + errorMessage);
                }
            }
            catch (Exception ex)
            {
                //If an error occurs while logging, display a message box with the error message
                MessageBox.Show($"An error occurred while logging: {ex.Message}");
            }
        }
        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e) //Show Password 
        {
            // If the "Show Password" checkbox is checked, display the password characters in plain text
            if (checkbxShowPas.Checked)
            {
                txtpassword.PasswordChar = '\0';
                txtComPassword.PasswordChar = '\0';
            }
            else //Otherwise - hide the password characters
            {
                txtpassword.PasswordChar = '*';
                txtComPassword.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e) //Clear text box Method
        {
            //Clear text boxes and set the cursor back to username text box
            txtusername.Text = "";
            txtpassword.Text = "";
            txtComPassword.Text = "";
            txtusername.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //Open a new instance of the login form and close the current registration form
            new frmLogin().Show();
            this.Hide();
        }
             

        private void button3_Click(object sender, EventArgs e) //Generate Password
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+";

            //Generate a random password
            var random = new Random();
            var password = new string(Enumerable.Repeat(chars, 10)
                .Select(s => s[random.Next(s.Length)]).ToArray());

            //Set password fields to the generated password
            txtpassword.Text = password;
            txtComPassword.Text = password;
        }

        private void button4_Click(object sender, EventArgs e) //Exit Button Method
        {
            //Exit and wait 2 seconds before closing the form
            System.Threading.Thread.Sleep(2000);
            Environment.Exit(0);
        }
    }
}