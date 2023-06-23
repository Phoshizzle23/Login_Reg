using Microsoft.VisualBasic.Logging;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Login_Reg
{
    public partial class dashboard : Form
    {
        /*
         * This code is for the dashboard form.
         * After the user is authenticated, they are navageted to this form.
         * The following is a breakdown of the code:
         * PictureBox4  - when clicked will navigate to the Admin form.
         * Home button - when clicked it will navigate to the login form.
         * button1 - when clicked it will exit the application with a 2 second delay.
        */
        public dashboard()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e) //Navigate to Admin form
        {
            new Admin().Show();
            this.Hide();
        }

        private void Home_Click(object sender, EventArgs e) //Navigate to Login form
        {
            new frmLogin().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e) //Exit Button Method
        {
            //Exit and wait 2 seconds before closing the form
            System.Threading.Thread.Sleep(2000);
            Environment.Exit(0);
        }
    }
}
