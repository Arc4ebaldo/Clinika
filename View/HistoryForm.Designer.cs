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
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            pictureBox4 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            BackBtn = new Button();
            FindBtn = new Button();
            button3 = new Button();
            EditBtn = new Button();
            SealBtn = new Button();
            DeleteBtn = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ID_Patient = new MaskedTextBox();
            Diagnosis = new TextBox();
            Medicines = new TextBox();
            label1 = new Label();
            AllHistory = new DataGridView();
            DataTime = new MaskedTextBox();
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
            button3.TabIndex = 56;
            button3.Text = "ДОБАВИТЬ";
            button3.UseVisualStyleBackColor = false;
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
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(639, 9);
            label4.Name = "label4";
            label4.Size = new Size(246, 22);
            label4.TabIndex = 51;
            label4.Text = "Прописанные лекарство";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(438, 9);
            label3.Name = "label3";
            label3.Size = new Size(87, 22);
            label3.TabIndex = 50;
            label3.Text = "Диагноз";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(198, 9);
            label2.Name = "label2";
            label2.Size = new Size(210, 22);
            label2.TabIndex = 49;
            label2.Text = "Дата начала лечения";
            // 
            // ID_Patient
            // 
            ID_Patient.BackColor = Color.LightSkyBlue;
            ID_Patient.BorderStyle = BorderStyle.FixedSingle;
            ID_Patient.Cursor = Cursors.IBeam;
            ID_Patient.Font = new Font("Century Gothic", 12F);
            ID_Patient.ForeColor = Color.FromArgb(15, 15, 15);
            ID_Patient.Location = new Point(12, 51);
            ID_Patient.Mask = "00000";
            ID_Patient.Name = "ID_Patient";
            ID_Patient.Size = new Size(152, 27);
            ID_Patient.TabIndex = 0;
            ID_Patient.ValidatingType = typeof(int);
            // 
            // Diagnosis
            // 
            Diagnosis.BackColor = Color.LightSkyBlue;
            Diagnosis.BorderStyle = BorderStyle.FixedSingle;
            Diagnosis.Cursor = Cursors.IBeam;
            Diagnosis.Font = new Font("Century Gothic", 12F);
            Diagnosis.ForeColor = Color.FromArgb(15, 15, 15);
            Diagnosis.Location = new Point(438, 51);
            Diagnosis.Name = "Diagnosis";
            Diagnosis.Size = new Size(162, 27);
            Diagnosis.TabIndex = 2;
            // 
            // Medicines
            // 
            Medicines.BackColor = Color.LightSkyBlue;
            Medicines.BorderStyle = BorderStyle.FixedSingle;
            Medicines.Cursor = Cursors.IBeam;
            Medicines.Font = new Font("Century Gothic", 12F);
            Medicines.ForeColor = Color.FromArgb(15, 15, 15);
            Medicines.Location = new Point(639, 51);
            Medicines.Name = "Medicines";
            Medicines.Size = new Size(226, 27);
            Medicines.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(127, 22);
            label1.TabIndex = 45;
            label1.Text = "ID Пациента";
            // 
            // AllHistory
            // 
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle17.BackColor = Color.LightSkyBlue;
            dataGridViewCellStyle17.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle17.ForeColor = Color.FromArgb(15, 15, 15);
            dataGridViewCellStyle17.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle17.SelectionForeColor = Color.SkyBlue;
            AllHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            AllHistory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AllHistory.BackgroundColor = Color.LightSkyBlue;
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle18.BackColor = Color.LightSkyBlue;
            dataGridViewCellStyle18.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle18.ForeColor = Color.FromArgb(15, 15, 15);
            dataGridViewCellStyle18.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle18.SelectionForeColor = Color.SkyBlue;
            dataGridViewCellStyle18.WrapMode = DataGridViewTriState.True;
            AllHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            AllHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle19.BackColor = Color.LightSkyBlue;
            dataGridViewCellStyle19.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle19.ForeColor = Color.FromArgb(15, 15, 15);
            dataGridViewCellStyle19.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle19.SelectionForeColor = Color.SkyBlue;
            dataGridViewCellStyle19.WrapMode = DataGridViewTriState.False;
            AllHistory.DefaultCellStyle = dataGridViewCellStyle19;
            AllHistory.GridColor = Color.LightBlue;
            AllHistory.Location = new Point(12, 104);
            AllHistory.Name = "AllHistory";
            dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle20.BackColor = Color.LightSkyBlue;
            dataGridViewCellStyle20.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle20.ForeColor = Color.FromArgb(15, 15, 15);
            dataGridViewCellStyle20.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle20.SelectionForeColor = Color.SkyBlue;
            dataGridViewCellStyle20.WrapMode = DataGridViewTriState.True;
            AllHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            AllHistory.Size = new Size(853, 566);
            AllHistory.TabIndex = 42;
            // 
            // DataTime
            // 
            DataTime.BackColor = Color.LightSkyBlue;
            DataTime.BorderStyle = BorderStyle.FixedSingle;
            DataTime.Cursor = Cursors.IBeam;
            DataTime.Font = new Font("Century Gothic", 12F);
            DataTime.ForeColor = Color.FromArgb(15, 15, 15);
            DataTime.Location = new Point(198, 51);
            DataTime.Mask = "00/00/0000";
            DataTime.Name = "DataTime";
            DataTime.Size = new Size(180, 27);
            DataTime.TabIndex = 1;
            DataTime.ValidatingType = typeof(DateTime);
            // 
            // HistoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 93, 142);
            ClientSize = new Size(1045, 682);
            Controls.Add(DataTime);
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
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ID_Patient);
            Controls.Add(Diagnosis);
            Controls.Add(Medicines);
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
        private Button button3;
        private Button EditBtn;
        private Button SealBtn;
        private Button DeleteBtn;
        private Label label4;
        private Label label3;
        private Label label2;
        private MaskedTextBox ID_Patient;
        private TextBox Diagnosis;
        private TextBox Medicines;
        private Label label1;
        private DataGridView AllHistory;
        private MaskedTextBox DataTime;
    }
}