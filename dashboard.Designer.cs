namespace Login_Reg
{
    partial class dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            Home = new PictureBox();
            Amin = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Home).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Amin).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(816, 454);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(116, 86, 174);
            label1.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(273, 181);
            label1.Name = "label1";
            label1.Size = new Size(257, 46);
            label1.TabIndex = 29;
            label1.Text = "Welcome!!!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(116, 86, 174);
            label2.Location = new Point(349, 256);
            label2.Name = "label2";
            label2.Size = new Size(100, 40);
            label2.TabIndex = 30;
            label2.Text = "user";
            // 
            // Home
            // 
            Home.Image = (Image)resources.GetObject("Home.Image");
            Home.Location = new Point(12, 12);
            Home.Name = "Home";
            Home.Size = new Size(67, 62);
            Home.SizeMode = PictureBoxSizeMode.Zoom;
            Home.TabIndex = 31;
            Home.TabStop = false;
            Home.Click += Home_Click;
            // 
            // Amin
            // 
            Amin.Image = (Image)resources.GetObject("Amin.Image");
            Amin.Location = new Point(12, 109);
            Amin.Name = "Amin";
            Amin.Size = new Size(67, 66);
            Amin.SizeMode = PictureBoxSizeMode.Zoom;
            Amin.TabIndex = 32;
            Amin.TabStop = false;
            Amin.Click += pictureBox4_Click;
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
            label3.TabIndex = 33;
            label3.Text = "Logoff";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(116, 86, 174);
            label4.Location = new Point(95, 121);
            label4.Name = "label4";
            label4.Size = new Size(94, 30);
            label4.TabIndex = 34;
            label4.Text = "Admin";
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(776, -1);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(24, 26);
            button1.TabIndex = 35;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Amin);
            Controls.Add(Home);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "dashboard";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Home).EndInit();
            ((System.ComponentModel.ISupportInitialize)Amin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private PictureBox Home;
        private PictureBox Amin;
        private Label label3;
        private Label label4;
        private Button button1;
    }
}