namespace Clinica.View
{
    partial class PatientForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientForm));
            AllPatient = new DataGridView();
            label1 = new Label();
            First_Name = new TextBox();
            Last_Name = new TextBox();
            Number = new MaskedTextBox();
            Email = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            DeleteBtn = new Button();
            SealBtn = new Button();
            EditBtn = new Button();
            AddBtn = new Button();
            FindBtn = new Button();
            BackBtn = new Button();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox4 = new PictureBox();
            Birthday = new MaskedTextBox();
            IDPole = new DataGridViewTextBoxColumn();
            NamePole = new DataGridViewTextBoxColumn();
            LastNamePole = new DataGridViewTextBoxColumn();
            BirthdayPole = new DataGridViewTextBoxColumn();
            NumberPole = new DataGridViewTextBoxColumn();
            EmailPole = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)AllPatient).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // AllPatient
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(15, 15, 15);
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.SkyBlue;
            AllPatient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            AllPatient.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AllPatient.BackgroundColor = Color.LightSkyBlue;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = Color.LightSkyBlue;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(15, 15, 15);
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.SkyBlue;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            AllPatient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            AllPatient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AllPatient.Columns.AddRange(new DataGridViewColumn[] { IDPole, NamePole, LastNamePole, BirthdayPole, NumberPole, EmailPole });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.BackColor = Color.LightSkyBlue;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(15, 15, 15);
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.SkyBlue;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            AllPatient.DefaultCellStyle = dataGridViewCellStyle3;
            AllPatient.GridColor = Color.LightBlue;
            AllPatient.Location = new Point(12, 104);
            AllPatient.Name = "AllPatient";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle4.BackColor = Color.LightSkyBlue;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(15, 15, 15);
            dataGridViewCellStyle4.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.SkyBlue;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            AllPatient.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            AllPatient.Size = new Size(853, 566);
            AllPatient.TabIndex = 0;
            AllPatient.RowHeaderMouseClick += AllPatient_RowHeaderMouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(49, 22);
            label1.TabIndex = 1;
            label1.Text = "Имя";
            // 
            // First_Name
            // 
            First_Name.BackColor = Color.LightSkyBlue;
            First_Name.BorderStyle = BorderStyle.FixedSingle;
            First_Name.Cursor = Cursors.IBeam;
            First_Name.Font = new Font("Century Gothic", 12F);
            First_Name.ForeColor = Color.FromArgb(15, 15, 15);
            First_Name.Location = new Point(12, 51);
            First_Name.Name = "First_Name";
            First_Name.Size = new Size(100, 27);
            First_Name.TabIndex = 0;
            // 
            // Last_Name
            // 
            Last_Name.BackColor = Color.LightSkyBlue;
            Last_Name.BorderStyle = BorderStyle.FixedSingle;
            Last_Name.Cursor = Cursors.IBeam;
            Last_Name.Font = new Font("Century Gothic", 12F);
            Last_Name.ForeColor = Color.FromArgb(15, 15, 15);
            Last_Name.Location = new Point(124, 51);
            Last_Name.Name = "Last_Name";
            Last_Name.Size = new Size(99, 27);
            Last_Name.TabIndex = 1;
            // 
            // Number
            // 
            Number.BackColor = Color.LightSkyBlue;
            Number.BorderStyle = BorderStyle.FixedSingle;
            Number.Cursor = Cursors.IBeam;
            Number.Font = new Font("Century Gothic", 12F);
            Number.ForeColor = Color.FromArgb(15, 15, 15);
            Number.Location = new Point(416, 51);
            Number.Mask = "(999) 000-0000";
            Number.Name = "Number";
            Number.Size = new Size(130, 27);
            Number.TabIndex = 3;
            // 
            // Email
            // 
            Email.BackColor = Color.LightSkyBlue;
            Email.BorderStyle = BorderStyle.FixedSingle;
            Email.Cursor = Cursors.IBeam;
            Email.Font = new Font("Century Gothic", 12F);
            Email.ForeColor = Color.FromArgb(15, 15, 15);
            Email.Location = new Point(611, 51);
            Email.Name = "Email";
            Email.Size = new Size(142, 27);
            Email.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(124, 9);
            label2.Name = "label2";
            label2.Size = new Size(99, 22);
            label2.TabIndex = 7;
            label2.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(249, 9);
            label3.Name = "label3";
            label3.Size = new Size(157, 22);
            label3.TabIndex = 8;
            label3.Text = "Дата рождения";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(416, 9);
            label4.Name = "label4";
            label4.Size = new Size(180, 22);
            label4.TabIndex = 9;
            label4.Text = "Номер телефона";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(611, 9);
            label5.Name = "label5";
            label5.Size = new Size(163, 22);
            label5.TabIndex = 10;
            label5.Text = "Адрес эл. почты";
            // 
            // DeleteBtn
            // 
            DeleteBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DeleteBtn.BackColor = Color.LightSkyBlue;
            DeleteBtn.Cursor = Cursors.Hand;
            DeleteBtn.FlatAppearance.BorderSize = 0;
            DeleteBtn.FlatAppearance.MouseDownBackColor = Color.SkyBlue;
            DeleteBtn.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            DeleteBtn.FlatStyle = FlatStyle.Flat;
            DeleteBtn.Font = new Font("Century Gothic", 14.25F);
            DeleteBtn.ForeColor = Color.FromArgb(15, 15, 15);
            DeleteBtn.Location = new Point(883, 255);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(150, 45);
            DeleteBtn.TabIndex = 11;
            DeleteBtn.Text = "УДАЛИТЬ";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // SealBtn
            // 
            SealBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SealBtn.BackColor = Color.LightSkyBlue;
            SealBtn.Cursor = Cursors.Hand;
            SealBtn.FlatAppearance.BorderSize = 0;
            SealBtn.FlatAppearance.MouseDownBackColor = Color.SkyBlue;
            SealBtn.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            SealBtn.FlatStyle = FlatStyle.Flat;
            SealBtn.Font = new Font("Century Gothic", 14.25F);
            SealBtn.ForeColor = Color.FromArgb(15, 15, 15);
            SealBtn.Location = new Point(883, 332);
            SealBtn.Name = "SealBtn";
            SealBtn.Size = new Size(150, 45);
            SealBtn.TabIndex = 12;
            SealBtn.Text = "ПЕЧАТЬ";
            SealBtn.UseVisualStyleBackColor = false;
            SealBtn.Click += SealBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EditBtn.BackColor = Color.LightSkyBlue;
            EditBtn.Cursor = Cursors.Hand;
            EditBtn.FlatAppearance.BorderSize = 0;
            EditBtn.FlatAppearance.MouseDownBackColor = Color.SkyBlue;
            EditBtn.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            EditBtn.FlatStyle = FlatStyle.Flat;
            EditBtn.Font = new Font("Century Gothic", 14.25F);
            EditBtn.ForeColor = Color.FromArgb(15, 15, 15);
            EditBtn.Location = new Point(883, 181);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(150, 45);
            EditBtn.TabIndex = 13;
            EditBtn.Text = "ИЗМЕНИТЬ";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddBtn.BackColor = Color.LightSkyBlue;
            AddBtn.Cursor = Cursors.Hand;
            AddBtn.FlatAppearance.BorderSize = 0;
            AddBtn.FlatAppearance.MouseDownBackColor = Color.SkyBlue;
            AddBtn.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.Font = new Font("Century Gothic", 14.25F);
            AddBtn.ForeColor = Color.FromArgb(15, 15, 15);
            AddBtn.Location = new Point(883, 104);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(150, 45);
            AddBtn.TabIndex = 14;
            AddBtn.Text = "ДОБАВИТЬ";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // FindBtn
            // 
            FindBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            FindBtn.BackColor = Color.LightSkyBlue;
            FindBtn.Cursor = Cursors.Hand;
            FindBtn.FlatAppearance.BorderSize = 0;
            FindBtn.FlatAppearance.MouseDownBackColor = Color.SkyBlue;
            FindBtn.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            FindBtn.FlatStyle = FlatStyle.Flat;
            FindBtn.Font = new Font("Century Gothic", 14.25F);
            FindBtn.ForeColor = Color.FromArgb(15, 15, 15);
            FindBtn.Location = new Point(883, 406);
            FindBtn.Name = "FindBtn";
            FindBtn.Size = new Size(150, 45);
            FindBtn.TabIndex = 15;
            FindBtn.Text = "ПОИСК";
            FindBtn.UseVisualStyleBackColor = false;
            // 
            // BackBtn
            // 
            BackBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BackBtn.BackColor = Color.LightSkyBlue;
            BackBtn.Cursor = Cursors.Hand;
            BackBtn.FlatAppearance.BorderSize = 0;
            BackBtn.FlatAppearance.MouseDownBackColor = Color.SkyBlue;
            BackBtn.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            BackBtn.FlatStyle = FlatStyle.Flat;
            BackBtn.Font = new Font("Century Gothic", 14.25F);
            BackBtn.ForeColor = Color.FromArgb(15, 15, 15);
            BackBtn.Location = new Point(883, 625);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(150, 45);
            BackBtn.TabIndex = 16;
            BackBtn.Text = "НАЗАД";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(962, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(16, 16);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.black;
            pictureBox2.Location = new Point(1028, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(16, 16);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.black__collapse_50;
            pictureBox1.Location = new Point(984, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(16, 16);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = Properties.Resources.black_expand_50;
            pictureBox4.Location = new Point(1006, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(16, 16);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 20;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // Birthday
            // 
            Birthday.BackColor = Color.LightSkyBlue;
            Birthday.BorderStyle = BorderStyle.FixedSingle;
            Birthday.Cursor = Cursors.IBeam;
            Birthday.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Birthday.ForeColor = Color.FromArgb(15, 15, 15);
            Birthday.Location = new Point(249, 51);
            Birthday.Mask = "00/00/0000";
            Birthday.Name = "Birthday";
            Birthday.Size = new Size(109, 27);
            Birthday.TabIndex = 2;
            Birthday.ValidatingType = typeof(DateTime);
            // 
            // IDPole
            // 
            IDPole.HeaderText = "ID";
            IDPole.Name = "IDPole";
            IDPole.ReadOnly = true;
            IDPole.Visible = false;
            // 
            // NamePole
            // 
            NamePole.HeaderText = "Имя";
            NamePole.Name = "NamePole";
            NamePole.ReadOnly = true;
            // 
            // LastNamePole
            // 
            LastNamePole.HeaderText = "Фамилия";
            LastNamePole.Name = "LastNamePole";
            LastNamePole.ReadOnly = true;
            // 
            // BirthdayPole
            // 
            BirthdayPole.HeaderText = "Дата рождения";
            BirthdayPole.Name = "BirthdayPole";
            BirthdayPole.ReadOnly = true;
            // 
            // NumberPole
            // 
            NumberPole.HeaderText = "Номер телефона";
            NumberPole.Name = "NumberPole";
            NumberPole.ReadOnly = true;
            NumberPole.Width = 150;
            // 
            // EmailPole
            // 
            EmailPole.HeaderText = "Адрес эл. почты";
            EmailPole.Name = "EmailPole";
            EmailPole.ReadOnly = true;
            EmailPole.Width = 150;
            // 
            // PatientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 93, 142);
            ClientSize = new Size(1045, 682);
            Controls.Add(Birthday);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(BackBtn);
            Controls.Add(FindBtn);
            Controls.Add(AddBtn);
            Controls.Add(EditBtn);
            Controls.Add(SealBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Email);
            Controls.Add(Number);
            Controls.Add(Last_Name);
            Controls.Add(First_Name);
            Controls.Add(label1);
            Controls.Add(AllPatient);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PatientForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PatientForm";
            Load += PatientForm_Load;
            MouseMove += PatientForm_MouseMove;
            ((System.ComponentModel.ISupportInitialize)AllPatient).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView AllPatient;
        private Label label1;
        private TextBox First_Name;
        private TextBox Last_Name;
        private MaskedTextBox Number;
        private TextBox Email;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button DeleteBtn;
        private Button SealBtn;
        private Button EditBtn;
        private Button AddBtn;
        private Button FindBtn;
        private Button BackBtn;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private MaskedTextBox Birthday;
        private DataGridViewTextBoxColumn IDPole;
        private DataGridViewTextBoxColumn NamePole;
        private DataGridViewTextBoxColumn LastNamePole;
        private DataGridViewTextBoxColumn BirthdayPole;
        private DataGridViewTextBoxColumn NumberPole;
        private DataGridViewTextBoxColumn EmailPole;
    }
}