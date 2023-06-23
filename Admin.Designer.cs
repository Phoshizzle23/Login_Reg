namespace Login_Reg
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            label3 = new Label();
            Home = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)Home).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(116, 86, 174);
            label3.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(95, 31);
            label3.Name = "label3";
            label3.Size = new Size(108, 30);
            label3.TabIndex = 35;
            label3.Text = "Logoff";
            // 
            // Home
            // 
            Home.Image = (Image)resources.GetObject("Home.Image");
            Home.Location = new Point(12, 12);
            Home.Name = "Home";
            Home.Size = new Size(67, 62);
            Home.SizeMode = PictureBoxSizeMode.Zoom;
            Home.TabIndex = 34;
            Home.TabStop = false;
            Home.Click += Home_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(116, 86, 174);
            label2.Location = new Point(348, 82);
            label2.Name = "label2";
            label2.Size = new Size(125, 40);
            label2.TabIndex = 37;
            label2.Text = "Admin";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(116, 86, 174);
            label1.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(285, 9);
            label1.Name = "label1";
            label1.Size = new Size(257, 46);
            label1.TabIndex = 36;
            label1.Text = "Welcome!!!";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(116, 86, 174);
            button1.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(285, 369);
            button1.Name = "button1";
            button1.Size = new Size(278, 69);
            button1.TabIndex = 38;
            button1.Text = "Generate User List";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(262, 148);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(323, 199);
            textBox1.TabIndex = 39;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(801, 451);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 40;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(116, 86, 174);
            button2.Location = new Point(585, 390);
            button2.Name = "button2";
            button2.Size = new Size(69, 34);
            button2.TabIndex = 41;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.IndianRed;
            button3.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(777, 2);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(24, 26);
            button3.TabIndex = 42;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(Home);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)Home).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private PictureBox Home;
        private Label label2;
        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Button button2;
        private Button button3;
    }
}