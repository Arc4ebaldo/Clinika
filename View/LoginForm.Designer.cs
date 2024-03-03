namespace Clinica
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            Login = new TextBox();
            Password = new TextBox();
            LogBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(415, 284);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(377, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(16, 16);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(399, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(16, 16);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.FromArgb(15, 15, 15);
            label2.Location = new Point(44, 26);
            label2.Name = "label2";
            label2.Size = new Size(324, 23);
            label2.TabIndex = 2;
            label2.Text = "СТОМАТОЛОГИЧЕСКАЯ КЛИНИКА";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(15, 15, 15);
            label1.Location = new Point(112, 241);
            label1.Name = "label1";
            label1.Size = new Size(207, 32);
            label1.TabIndex = 1;
            label1.Text = "АВТОРИЗАЦИЯ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(121, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(187, 174);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            Login.BackColor = Color.FromArgb(15, 15, 15);
            Login.BorderStyle = BorderStyle.FixedSingle;
            Login.Cursor = Cursors.IBeam;
            Login.Font = new Font("Century Gothic", 15.75F);
            Login.ForeColor = Color.DimGray;
            Login.Location = new Point(41, 356);
            Login.Name = "Login";
            Login.Size = new Size(327, 33);
            Login.TabIndex = 1;
            Login.Text = "ЛОГИН";
            Login.Enter += Login_Enter;
            Login.Leave += Login_Leave;
            // 
            // Password
            // 
            Password.BackColor = Color.FromArgb(15, 15, 15);
            Password.BorderStyle = BorderStyle.FixedSingle;
            Password.Cursor = Cursors.IBeam;
            Password.Font = new Font("Century Gothic", 15.75F);
            Password.ForeColor = Color.DimGray;
            Password.Location = new Point(41, 436);
            Password.Name = "Password";
            Password.Size = new Size(331, 33);
            Password.TabIndex = 2;
            Password.Text = "ПАРОЛЬ";
            Password.Enter += Password_Enter;
            Password.Leave += Password_Leave;
            // 
            // LogBtn
            // 
            LogBtn.BackColor = Color.FromArgb(40, 40, 40);
            LogBtn.Cursor = Cursors.Hand;
            LogBtn.FlatAppearance.BorderSize = 0;
            LogBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            LogBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            LogBtn.FlatStyle = FlatStyle.Flat;
            LogBtn.Font = new Font("Century Gothic", 12F);
            LogBtn.ForeColor = Color.LightGray;
            LogBtn.Location = new Point(41, 521);
            LogBtn.Name = "LogBtn";
            LogBtn.Size = new Size(331, 51);
            LogBtn.TabIndex = 3;
            LogBtn.Text = "ВОЙТИ";
            LogBtn.UseVisualStyleBackColor = false;
            LogBtn.Click += LogBtn_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(415, 600);
            Controls.Add(LogBtn);
            Controls.Add(Password);
            Controls.Add(Login);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            MouseDown += LoginForm_MouseDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox Login;
        private TextBox Password;
        private Button LogBtn;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}
