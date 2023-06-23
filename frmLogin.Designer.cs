namespace Login_Reg
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            label6 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            button1 = new Button();
            checkbxShowPas = new CheckBox();
            txtpassword = new TextBox();
            label3 = new Label();
            txtusername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.ForeColor = Color.FromArgb(116, 86, 174);
            label6.Location = new Point(132, 482);
            label6.Name = "label6";
            label6.Size = new Size(121, 17);
            label6.TabIndex = 25;
            label6.Text = "Create Account";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(103, 451);
            label5.Name = "label5";
            label5.Size = new Size(176, 17);
            label5.TabIndex = 24;
            label5.Text = "Don't Have An Account?";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(119, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(116, 86, 174);
            button2.Location = new Point(78, 402);
            button2.Name = "button2";
            button2.Size = new Size(216, 35);
            button2.TabIndex = 22;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(116, 86, 174);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(78, 361);
            button1.Name = "button1";
            button1.Size = new Size(216, 35);
            button1.TabIndex = 21;
            button1.Text = "LOG IN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // checkbxShowPas
            // 
            checkbxShowPas.AutoSize = true;
            checkbxShowPas.Cursor = Cursors.Hand;
            checkbxShowPas.FlatStyle = FlatStyle.Flat;
            checkbxShowPas.Location = new Point(152, 291);
            checkbxShowPas.Name = "checkbxShowPas";
            checkbxShowPas.Size = new Size(142, 21);
            checkbxShowPas.TabIndex = 20;
            checkbxShowPas.Text = "Show Password";
            checkbxShowPas.UseVisualStyleBackColor = true;
            checkbxShowPas.CheckedChanged += checkbxShowPas_CheckedChanged;
            // 
            // txtpassword
            // 
            txtpassword.BackColor = Color.FromArgb(230, 231, 233);
            txtpassword.BorderStyle = BorderStyle.None;
            txtpassword.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtpassword.Location = new Point(78, 257);
            txtpassword.Multiline = true;
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(216, 28);
            txtpassword.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(11, 86, 174);
            label3.Location = new Point(78, 225);
            label3.Name = "label3";
            label3.Size = new Size(82, 17);
            label3.TabIndex = 16;
            label3.Text = "Password";
            // 
            // txtusername
            // 
            txtusername.BackColor = Color.FromArgb(230, 231, 233);
            txtusername.BorderStyle = BorderStyle.None;
            txtusername.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtusername.Location = new Point(78, 176);
            txtusername.Multiline = true;
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(216, 28);
            txtusername.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(11, 86, 174);
            label2.Location = new Point(78, 144);
            label2.Name = "label2";
            label2.Size = new Size(76, 17);
            label2.TabIndex = 14;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(11, 86, 174);
            label1.Location = new Point(78, 114);
            label1.Name = "label1";
            label1.Size = new Size(137, 23);
            label1.TabIndex = 13;
            label1.Text = "Get Started";
            // 
            // button3
            // 
            button3.BackColor = Color.IndianRed;
            button3.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(349, 0);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(24, 26);
            button3.TabIndex = 36;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(372, 554);
            Controls.Add(button3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkbxShowPas);
            Controls.Add(txtpassword);
            Controls.Add(label3);
            Controls.Add(txtusername);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private PictureBox pictureBox1;
        private Button button2;
        private Button button1;
        private CheckBox checkbxShowPas;
        private TextBox txtpassword;
        private Label label3;
        private TextBox txtusername;
        private Label label2;
        private Label label1;
        private Button button3;
    }
}