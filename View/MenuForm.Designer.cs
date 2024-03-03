namespace Clinica.View
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            historyBtn = new Button();
            serviceBtn = new Button();
            apoointmentBtn = new Button();
            doctorBtn = new Button();
            patientBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(13, 93, 142);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(991, 37);
            panel2.TabIndex = 2;
            panel2.MouseMove += panel2_MouseMove;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(950, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(16, 16);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(972, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(16, 16);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(4, 41, 68);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(historyBtn);
            panel1.Controls.Add(serviceBtn);
            panel1.Controls.Add(apoointmentBtn);
            panel1.Controls.Add(doctorBtn);
            panel1.Controls.Add(patientBtn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(262, 554);
            panel1.TabIndex = 3;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.logo2;
            pictureBox4.Location = new Point(23, 6);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(211, 182);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // historyBtn
            // 
            historyBtn.BackColor = Color.FromArgb(13, 93, 142);
            historyBtn.Cursor = Cursors.Hand;
            historyBtn.FlatAppearance.BorderSize = 0;
            historyBtn.FlatAppearance.MouseDownBackColor = Color.Teal;
            historyBtn.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            historyBtn.FlatStyle = FlatStyle.Flat;
            historyBtn.Font = new Font("Century Gothic", 14.25F);
            historyBtn.ForeColor = Color.FromArgb(15, 15, 15);
            historyBtn.Location = new Point(12, 483);
            historyBtn.Name = "historyBtn";
            historyBtn.Size = new Size(234, 45);
            historyBtn.TabIndex = 4;
            historyBtn.Text = "ИСТОРИЯ БОЛЕЗНЕЙ";
            historyBtn.UseVisualStyleBackColor = false;
            historyBtn.Click += historyBtn_Click;
            // 
            // serviceBtn
            // 
            serviceBtn.BackColor = Color.FromArgb(13, 93, 142);
            serviceBtn.Cursor = Cursors.Hand;
            serviceBtn.FlatAppearance.BorderSize = 0;
            serviceBtn.FlatAppearance.MouseDownBackColor = Color.Teal;
            serviceBtn.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            serviceBtn.FlatStyle = FlatStyle.Flat;
            serviceBtn.Font = new Font("Century Gothic", 14.25F);
            serviceBtn.ForeColor = Color.FromArgb(15, 15, 15);
            serviceBtn.Location = new Point(12, 414);
            serviceBtn.Name = "serviceBtn";
            serviceBtn.Size = new Size(234, 45);
            serviceBtn.TabIndex = 3;
            serviceBtn.Text = "УСЛУГИ";
            serviceBtn.UseVisualStyleBackColor = false;
            serviceBtn.Click += serviceBtn_Click;
            // 
            // apoointmentBtn
            // 
            apoointmentBtn.BackColor = Color.FromArgb(13, 93, 142);
            apoointmentBtn.Cursor = Cursors.Hand;
            apoointmentBtn.FlatAppearance.BorderSize = 0;
            apoointmentBtn.FlatAppearance.MouseDownBackColor = Color.Teal;
            apoointmentBtn.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            apoointmentBtn.FlatStyle = FlatStyle.Flat;
            apoointmentBtn.Font = new Font("Century Gothic", 14.25F);
            apoointmentBtn.ForeColor = Color.FromArgb(15, 15, 15);
            apoointmentBtn.Location = new Point(12, 341);
            apoointmentBtn.Name = "apoointmentBtn";
            apoointmentBtn.Size = new Size(234, 45);
            apoointmentBtn.TabIndex = 2;
            apoointmentBtn.Text = "ЗАПИСИ НА ПРИЁМ";
            apoointmentBtn.UseVisualStyleBackColor = false;
            apoointmentBtn.Click += apoointmentBtn_Click;
            // 
            // doctorBtn
            // 
            doctorBtn.BackColor = Color.FromArgb(13, 93, 142);
            doctorBtn.Cursor = Cursors.Hand;
            doctorBtn.FlatAppearance.BorderSize = 0;
            doctorBtn.FlatAppearance.MouseDownBackColor = Color.Teal;
            doctorBtn.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            doctorBtn.FlatStyle = FlatStyle.Flat;
            doctorBtn.Font = new Font("Century Gothic", 14.25F);
            doctorBtn.ForeColor = Color.FromArgb(15, 15, 15);
            doctorBtn.Location = new Point(12, 273);
            doctorBtn.Name = "doctorBtn";
            doctorBtn.Size = new Size(234, 45);
            doctorBtn.TabIndex = 1;
            doctorBtn.Text = "ВРАЧИ";
            doctorBtn.UseVisualStyleBackColor = false;
            doctorBtn.Click += doctorBtn_Click;
            // 
            // patientBtn
            // 
            patientBtn.BackColor = Color.FromArgb(13, 93, 142);
            patientBtn.Cursor = Cursors.Hand;
            patientBtn.FlatAppearance.BorderSize = 0;
            patientBtn.FlatAppearance.MouseDownBackColor = Color.Teal;
            patientBtn.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            patientBtn.FlatStyle = FlatStyle.Flat;
            patientBtn.Font = new Font("Century Gothic", 14.25F);
            patientBtn.ForeColor = Color.FromArgb(15, 15, 15);
            patientBtn.Location = new Point(12, 201);
            patientBtn.Name = "patientBtn";
            patientBtn.Size = new Size(234, 45);
            patientBtn.TabIndex = 0;
            patientBtn.Text = "ПАЦИЕНТЫ";
            patientBtn.UseVisualStyleBackColor = false;
            patientBtn.Click += patientBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(15, 15, 15);
            label1.Location = new Point(329, 83);
            label1.Name = "label1";
            label1.Size = new Size(326, 32);
            label1.TabIndex = 7;
            label1.Text = "СТОМАТОЛОГИЧЕСКАЯ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(15, 15, 15);
            label2.Location = new Point(329, 153);
            label2.Name = "label2";
            label2.Size = new Size(143, 32);
            label2.TabIndex = 8;
            label2.Text = "КЛИНИКА";
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.bg1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(991, 591);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuForm";
            Load += MenuForm_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel1;
        private Button historyBtn;
        private Button serviceBtn;
        private Button apoointmentBtn;
        private Button doctorBtn;
        private Button patientBtn;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private Label label1;
        private Label label2;
    }
}