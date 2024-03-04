namespace Clinica.View
{
    partial class HistoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pictureBox4 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            BackBtn = new Button();
            FindBtn = new Button();
            AddBtn = new Button();
            EditBtn = new Button();
            SealBtn = new Button();
            DeleteBtn = new Button();
            label3 = new Label();
            label2 = new Label();
            Diagnosis = new TextBox();
            label1 = new Label();
            AllHistory = new DataGridView();
            IDPole = new DataGridViewTextBoxColumn();
            PatientNamePole = new DataGridViewTextBoxColumn();
            PatientLastNamePole = new DataGridViewTextBoxColumn();
            DataStartPole = new DataGridViewTextBoxColumn();
            DataEndPole = new DataGridViewTextBoxColumn();
            DiagnosePole = new DataGridViewTextBoxColumn();
            startDay = new MaskedTextBox();
            label5 = new Label();
            stopDay = new MaskedTextBox();
            ID_Patient = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AllHistory).BeginInit();
            SuspendLayout();
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
            pictureBox4.TabIndex = 62;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
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
            pictureBox1.TabIndex = 61;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
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
            pictureBox3.TabIndex = 60;
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
            pictureBox2.TabIndex = 59;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
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
            BackBtn.TabIndex = 58;
            BackBtn.Text = "НАЗАД";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
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
            FindBtn.TabIndex = 57;
            FindBtn.Text = "ПОИСК";
            FindBtn.UseVisualStyleBackColor = false;
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
            AddBtn.TabIndex = 56;
            AddBtn.Text = "ДОБАВИТЬ";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
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
            EditBtn.TabIndex = 55;
            EditBtn.Text = "ИЗМЕНИТЬ";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
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
            SealBtn.TabIndex = 54;
            SealBtn.Text = "ПЕЧАТЬ";
            SealBtn.UseVisualStyleBackColor = false;
            SealBtn.Click += SealBtn_Click;
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
            DeleteBtn.TabIndex = 53;
            DeleteBtn.Text = "УДАЛИТЬ";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(545, 9);
            label3.Name = "label3";
            label3.Size = new Size(87, 22);
            label3.TabIndex = 50;
            label3.Text = "Диагноз";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(185, 9);
            label2.Name = "label2";
            label2.Size = new Size(209, 22);
            label2.TabIndex = 49;
            label2.Text = "Дата начало лечения";
            // 
            // Diagnosis
            // 
            Diagnosis.BackColor = Color.LightSkyBlue;
            Diagnosis.BorderStyle = BorderStyle.FixedSingle;
            Diagnosis.Cursor = Cursors.IBeam;
            Diagnosis.Font = new Font("Century Gothic", 12F);
            Diagnosis.ForeColor = Color.FromArgb(15, 15, 15);
            Diagnosis.Location = new Point(545, 51);
            Diagnosis.Name = "Diagnosis";
            Diagnosis.Size = new Size(131, 27);
            Diagnosis.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(156, 22);
            label1.TabIndex = 45;
            label1.Text = "ФИО Пациента";
            // 
            // AllHistory
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(15, 15, 15);
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.SkyBlue;
            AllHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            AllHistory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AllHistory.BackgroundColor = Color.LightSkyBlue;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = Color.LightSkyBlue;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(15, 15, 15);
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.SkyBlue;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            AllHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            AllHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AllHistory.Columns.AddRange(new DataGridViewColumn[] { IDPole, PatientNamePole, PatientLastNamePole, DataStartPole, DataEndPole, DiagnosePole });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.BackColor = Color.LightSkyBlue;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(15, 15, 15);
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.SkyBlue;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            AllHistory.DefaultCellStyle = dataGridViewCellStyle3;
            AllHistory.GridColor = Color.LightBlue;
            AllHistory.Location = new Point(12, 104);
            AllHistory.Name = "AllHistory";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle4.BackColor = Color.LightSkyBlue;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(15, 15, 15);
            dataGridViewCellStyle4.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.SkyBlue;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            AllHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            AllHistory.Size = new Size(853, 566);
            AllHistory.TabIndex = 42;
            AllHistory.RowHeaderMouseClick += AllHistory_RowHeaderMouseClick;
            // 
            // IDPole
            // 
            IDPole.HeaderText = "ID";
            IDPole.Name = "IDPole";
            IDPole.ReadOnly = true;
            IDPole.Visible = false;
            // 
            // PatientNamePole
            // 
            PatientNamePole.HeaderText = "Имя пациента";
            PatientNamePole.Name = "PatientNamePole";
            PatientNamePole.ReadOnly = true;
            // 
            // PatientLastNamePole
            // 
            PatientLastNamePole.HeaderText = "Фамилия пациента";
            PatientLastNamePole.Name = "PatientLastNamePole";
            PatientLastNamePole.ReadOnly = true;
            // 
            // DataStartPole
            // 
            DataStartPole.HeaderText = "Дата начала лечения";
            DataStartPole.Name = "DataStartPole";
            DataStartPole.ReadOnly = true;
            DataStartPole.Width = 150;
            // 
            // DataEndPole
            // 
            DataEndPole.HeaderText = "Дата конца лечения";
            DataEndPole.Name = "DataEndPole";
            DataEndPole.ReadOnly = true;
            DataEndPole.Width = 150;
            // 
            // DiagnosePole
            // 
            DiagnosePole.HeaderText = "Диагноз";
            DiagnosePole.Name = "DiagnosePole";
            DiagnosePole.ReadOnly = true;
            // 
            // startDay
            // 
            startDay.BackColor = Color.LightSkyBlue;
            startDay.BorderStyle = BorderStyle.FixedSingle;
            startDay.Cursor = Cursors.IBeam;
            startDay.Font = new Font("Century Gothic", 12F);
            startDay.ForeColor = Color.FromArgb(15, 15, 15);
            startDay.Location = new Point(185, 51);
            startDay.Mask = "00/00/0000";
            startDay.Name = "startDay";
            startDay.Size = new Size(147, 27);
            startDay.TabIndex = 1;
            startDay.ValidatingType = typeof(DateTime);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(400, 9);
            label5.Name = "label5";
            label5.Size = new Size(120, 22);
            label5.TabIndex = 63;
            label5.Text = "Дата конца";
            // 
            // stopDay
            // 
            stopDay.BackColor = Color.LightSkyBlue;
            stopDay.BorderStyle = BorderStyle.FixedSingle;
            stopDay.Cursor = Cursors.IBeam;
            stopDay.Font = new Font("Century Gothic", 12F);
            stopDay.ForeColor = Color.FromArgb(15, 15, 15);
            stopDay.Location = new Point(388, 51);
            stopDay.Mask = "00/00/0000";
            stopDay.Name = "stopDay";
            stopDay.Size = new Size(132, 27);
            stopDay.TabIndex = 2;
            stopDay.ValidatingType = typeof(DateTime);
            // 
            // ID_Patient
            // 
            ID_Patient.BackColor = Color.LightSkyBlue;
            ID_Patient.BorderStyle = BorderStyle.FixedSingle;
            ID_Patient.Cursor = Cursors.IBeam;
            ID_Patient.Font = new Font("Century Gothic", 12F);
            ID_Patient.ForeColor = Color.FromArgb(15, 15, 15);
            ID_Patient.Location = new Point(12, 51);
            ID_Patient.Name = "ID_Patient";
            ID_Patient.Size = new Size(131, 27);
            ID_Patient.TabIndex = 0;
            // 
            // HistoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 93, 142);
            ClientSize = new Size(1045, 682);
            Controls.Add(ID_Patient);
            Controls.Add(stopDay);
            Controls.Add(label5);
            Controls.Add(startDay);
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
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Diagnosis);
            Controls.Add(label1);
            Controls.Add(AllHistory);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HistoryForm";
            Text = "HistoryForm";
            Load += HistoryForm_Load;
            MouseMove += HistoryForm_MouseMove;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)AllHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Button BackBtn;
        private Button FindBtn;
        private Button AddBtn;
        private Button EditBtn;
        private Button SealBtn;
        private Button DeleteBtn;
        private Label label3;
        private Label label2;
        private TextBox Diagnosis;
        private Label label1;
        private DataGridView AllHistory;
        private MaskedTextBox startDay;
        private Label label5;
        private MaskedTextBox stopDay;
        private TextBox ID_Patient;
        private DataGridViewTextBoxColumn IDPole;
        private DataGridViewTextBoxColumn PatientNamePole;
        private DataGridViewTextBoxColumn PatientLastNamePole;
        private DataGridViewTextBoxColumn DataStartPole;
        private DataGridViewTextBoxColumn DataEndPole;
        private DataGridViewTextBoxColumn DiagnosePole;
    }
}