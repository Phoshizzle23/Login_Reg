namespace Login_Reg
{
    partial class frmRegister
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            label1 = new Label();
            label2 = new Label();
            txtusername = new TextBox();
            txtpassword = new TextBox();
            label3 = new Label();
            txtComPassword = new TextBox();
            label4 = new Label();
            checkbxShowPas = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(11, 86, 174);
            label1.Location = new Point(28, 102);
            label1.Name = "label1";
            label1.Size = new Size(137, 23);
            label1.TabIndex = 0;
            label1.Text = "Get Started";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(11, 86, 174);
            label2.Location = new Point(28, 132);
            label2.Name = "label2";
            label2.Size = new Size(76, 17);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // txtusername
            // 
            txtusername.BackColor = Color.FromArgb(230, 231, 233);
            txtusername.BorderStyle = BorderStyle.None;
            txtusername.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtusername.Location = new Point(28, 164);
            txtusername.Multiline = true;
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(216, 28);
            txtusername.TabIndex = 2;
            // 
            // txtpassword
            // 
            txtpassword.BackColor = Color.FromArgb(230, 231, 233);
            txtpassword.BorderStyle = BorderStyle.None;
            txtpassword.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtpassword.Location = new Point(28, 245);
            txtpassword.Multiline = true;
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(216, 28);
            txtpassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(11, 86, 174);
            label3.Location = new Point(28, 213);
            label3.Name = "label3";
            label3.Size = new Size(82, 17);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // txtComPassword
            // 
            txtComPassword.BackColor = Color.FromArgb(230, 231, 233);
            txtComPassword.BorderStyle = BorderStyle.None;
            txtComPassword.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtComPassword.Location = new Point(28, 324);
            txtComPassword.Multiline = true;
            txtComPassword.Name = "txtComPassword";
            txtComPassword.PasswordChar = '*';
            txtComPassword.Size = new Size(216, 28);
            txtComPassword.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(11, 86, 174);
            label4.Location = new Point(28, 292);
            label4.Name = "label4";
            label4.Size = new Size(144, 17);
            label4.TabIndex = 5;
            label4.Text = "Confirm Password";
            // 
            // checkbxShowPas
            // 
            checkbxShowPas.AutoSize = true;
            checkbxShowPas.Cursor = Cursors.Hand;
            checkbxShowPas.FlatStyle = FlatStyle.Flat;
            checkbxShowPas.Location = new Point(102, 370);
            checkbxShowPas.Name = "checkbxShowPas";
            checkbxShowPas.Size = new Size(142, 21);
            checkbxShowPas.TabIndex = 7;
            checkbxShowPas.Text = "Show Password";
            checkbxShowPas.UseVisualStyleBackColor = true;
            checkbxShowPas.CheckedChanged += checkbxShowPas_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(116, 86, 174);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(31, 481);
            button1.Name = "button1";
            button1.Size = new Size(216, 35);
            button1.TabIndex = 8;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(116, 86, 174);
            button2.Location = new Point(31, 541);
            button2.Name = "button2";
            button2.Size = new Size(216, 35);
            button2.TabIndex = 9;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(72, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 591);
            label5.Name = "label5";
            label5.Size = new Size(193, 17);
            label5.TabIndex = 11;
            label5.Text = "Already Have An Account?";
            
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.ForeColor = Color.FromArgb(116, 86, 174);
            label6.Location = new Point(85, 621);
            label6.Name = "label6";
            label6.Size = new Size(110, 17);
            label6.TabIndex = 12;
            label6.Text = "Back to LOG IN";
            label6.Click += label6_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.FromArgb(116, 86, 174);
            button3.Location = new Point(31, 417);
            button3.Name = "button3";
            button3.Size = new Size(216, 35);
            button3.TabIndex = 14;
            button3.Text = "Generate Password";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.IndianRed;
            button4.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(256, 0);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(24, 26);
            button4.TabIndex = 37;
            button4.Text = "X";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(277, 661);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkbxShowPas);
            Controls.Add(txtComPassword);
            Controls.Add(label4);
            Controls.Add(txtpassword);
            Controls.Add(label3);
            Controls.Add(txtusername);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtusername;
        private TextBox txtpassword;
        private Label label3;
        private TextBox txtComPassword;
        private Label label4;
        private CheckBox checkbxShowPas;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label6;
        private Button button3;
        private Button button4;
    }
}