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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
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
            button3 = new Button();
            FindBtn = new Button();
            BackBtn = new Button();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox4 = new PictureBox();
            Birthday = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)AllPatient).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // AllPatient
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle5.BackColor = Color.LightSkyBlue;
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(15, 15, 15);
            dataGridViewCellStyle5.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = Color.SkyBlue;
            AllPatient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            AllPatient.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AllPatient.BackgroundColor = Color.LightSkyBlue;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle6.BackColor = Color.LightSkyBlue;
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(15, 15, 15);
            dataGridViewCellStyle6.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = Color.SkyBlue;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            AllPatient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            AllPatient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle7.BackColor = Color.LightSkyBlue;
            dataGridViewCellStyle7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(15, 15, 15);
            dataGridViewCellStyle7.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle7.SelectionForeColor = Color.SkyBlue;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            AllPatient.DefaultCellStyle = dataGridViewCellStyle7;
            AllPatient.GridColor = Color.LightBlue;
            AllPatient.Location = new Point(12, 104);
            AllPatient.Name = "AllPatient";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle8.BackColor = Color.LightSkyBlue;
            dataGridViewCellStyle8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(15, 15, 15);
            dataGridViewCellStyle8.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = Color.SkyBlue;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            AllPatient.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            AllPatient.Size = new Size(853, 566);
            AllPatient.TabIndex = 0;
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
            Last_Name.Location = new Point(153, 51);
            Last_Name.Name = "Last_Name";
            Last_Name.Size = new Size(100, 27);
            Last_Name.TabIndex = 1;
            // 
            // Number
            // 
            Number.BackColor = Color.LightSkyBlue;
            Number.BorderStyle = BorderStyle.FixedSingle;
            Number.Cursor = Cursors.IBeam;
            Number.Font = new Font("Century Gothic", 12F);
            Number.ForeColor = Color.FromArgb(15, 15, 15);
            Number.Location = new Point(481, 51);
            Number.Mask = "(999) 000-0000";
            Number.Name = "Number";
            Number.Size = new Size(180, 27);
            Number.TabIndex = 3;
            // 
            // Email
            // 
            Email.BackColor = Color.LightSkyBlue;
            Email.BorderStyle = BorderStyle.FixedSingle;
            Email.Cursor = Cursors.IBeam;
            Email.Font = new Font("Century Gothic", 12F);
            Email.ForeColor = Color.FromArgb(15, 15, 15);
            Email.Location = new Point(702, 51);
            Email.Name = "Email";
            Email.Size = new Size(163, 27);
            Email.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(153, 9);
            label2.Name = "label2";
            label2.Size = new Size(99, 22);
            label2.TabIndex = 7;
            label2.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(292, 9);
            label3.Name = "label3";
            label3.Size = new Size(157, 22);
            label3.TabIndex = 8;
            label3.Text = "Дата рождения";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(481, 9);
            label4.Name = "label4";
            label4.Size = new Size(180, 22);
            label4.TabIndex = 9;
            label4.Text = "Номер телефона";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(702, 9);
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
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.BackColor = Color.LightSkyBlue;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.SkyBlue;
            button3.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 14.25F);
            button3.ForeColor = Color.FromArgb(15, 15, 15);
            button3.Location = new Point(883, 104);
            button3.Name = "button3";
            button3.Size = new Size(150, 45);
            button3.TabIndex = 14;
            button3.Text = "ДОБАВИТЬ";
            button3.UseVisualStyleBackColor = false;
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
            Birthday.Location = new Point(292, 51);
            Birthday.Mask = "00/00/0000";
            Birthday.Name = "Birthday";
            Birthday.Size = new Size(157, 27);
            Birthday.TabIndex = 2;
            Birthday.ValidatingType = typeof(DateTime);
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
            Controls.Add(button3);
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
        private Button button3;
        private Button FindBtn;
        private Button BackBtn;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private MaskedTextBox Birthday;
    }
}