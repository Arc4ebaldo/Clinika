namespace Clinica.View
{
    partial class AppointmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentForm));
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ID_Patient = new TextBox();
            label1 = new Label();
            AllAppointment = new DataGridView();
            DataTime = new MaskedTextBox();
            ID_Doctor = new TextBox();
            Problem = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AllAppointment).BeginInit();
            SuspendLayout();
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = Properties.Resources.black_expand_50;
            pictureBox4.Location = new Point(1007, 0);
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
            pictureBox1.Location = new Point(985, 0);
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
            pictureBox3.Location = new Point(963, 0);
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
            pictureBox2.Location = new Point(1029, 0);
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
            BackBtn.Location = new Point(884, 625);
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
            FindBtn.Location = new Point(884, 406);
            FindBtn.Name = "FindBtn";
            FindBtn.Size = new Size(150, 45);
            FindBtn.TabIndex = 57;
            FindBtn.Text = "ПОИСК";
            FindBtn.UseVisualStyleBackColor = false;
            FindBtn.Click += FindBtn_Click;
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
            AddBtn.Location = new Point(884, 104);
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
            EditBtn.Location = new Point(884, 181);
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
            SealBtn.Location = new Point(884, 332);
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
            DeleteBtn.Location = new Point(884, 255);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(150, 45);
            DeleteBtn.TabIndex = 53;
            DeleteBtn.Text = "УДАЛИТЬ";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(577, 9);
            label4.Name = "label4";
            label4.Size = new Size(216, 22);
            label4.TabIndex = 51;
            label4.Text = "Описание проблемы";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(419, 9);
            label3.Name = "label3";
            label3.Size = new Size(122, 22);
            label3.TabIndex = 50;
            label3.Text = "ФИО Врача";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(257, 9);
            label2.Name = "label2";
            label2.Size = new Size(156, 22);
            label2.TabIndex = 49;
            label2.Text = "ФИО Пациента";
            // 
            // ID_Patient
            // 
            ID_Patient.BackColor = Color.LightSkyBlue;
            ID_Patient.BorderStyle = BorderStyle.FixedSingle;
            ID_Patient.Cursor = Cursors.IBeam;
            ID_Patient.Font = new Font("Century Gothic", 12F);
            ID_Patient.ForeColor = Color.FromArgb(15, 15, 15);
            ID_Patient.Location = new Point(257, 51);
            ID_Patient.Name = "ID_Patient";
            ID_Patient.Size = new Size(127, 27);
            ID_Patient.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(13, 9);
            label1.Name = "label1";
            label1.Size = new Size(221, 22);
            label1.TabIndex = 45;
            label1.Text = "Дата и время приема";
            // 
            // AllAppointment
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(15, 15, 15);
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.SkyBlue;
            AllAppointment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            AllAppointment.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AllAppointment.BackgroundColor = Color.LightSkyBlue;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = Color.LightSkyBlue;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(15, 15, 15);
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.SkyBlue;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            AllAppointment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            AllAppointment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.BackColor = Color.LightSkyBlue;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(15, 15, 15);
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.SkyBlue;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            AllAppointment.DefaultCellStyle = dataGridViewCellStyle3;
            AllAppointment.GridColor = Color.LightBlue;
            AllAppointment.Location = new Point(13, 104);
            AllAppointment.Name = "AllAppointment";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle4.BackColor = Color.LightSkyBlue;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(15, 15, 15);
            dataGridViewCellStyle4.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.SkyBlue;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            AllAppointment.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            AllAppointment.Size = new Size(853, 566);
            AllAppointment.TabIndex = 42;
            AllAppointment.RowHeaderMouseClick += AllAppointment_RowHeaderMouseClick;
            // 
            // DataTime
            // 
            DataTime.BackColor = Color.LightSkyBlue;
            DataTime.BorderStyle = BorderStyle.FixedSingle;
            DataTime.Cursor = Cursors.IBeam;
            DataTime.Font = new Font("Century Gothic", 12F);
            DataTime.ForeColor = Color.FromArgb(15, 15, 15);
            DataTime.Location = new Point(12, 51);
            DataTime.Mask = "00/00/0000 90:00";
            DataTime.Name = "DataTime";
            DataTime.Size = new Size(134, 27);
            DataTime.TabIndex = 0;
            DataTime.ValidatingType = typeof(DateTime);
            // 
            // ID_Doctor
            // 
            ID_Doctor.BackColor = Color.LightSkyBlue;
            ID_Doctor.BorderStyle = BorderStyle.FixedSingle;
            ID_Doctor.Cursor = Cursors.IBeam;
            ID_Doctor.Font = new Font("Century Gothic", 12F);
            ID_Doctor.ForeColor = Color.FromArgb(15, 15, 15);
            ID_Doctor.Location = new Point(419, 51);
            ID_Doctor.Name = "ID_Doctor";
            ID_Doctor.Size = new Size(127, 27);
            ID_Doctor.TabIndex = 2;
            // 
            // Problem
            // 
            Problem.BackColor = Color.LightSkyBlue;
            Problem.BorderStyle = BorderStyle.FixedSingle;
            Problem.Cursor = Cursors.IBeam;
            Problem.Font = new Font("Century Gothic", 12F);
            Problem.ForeColor = Color.FromArgb(15, 15, 15);
            Problem.Location = new Point(577, 51);
            Problem.Name = "Problem";
            Problem.Size = new Size(216, 27);
            Problem.TabIndex = 3;
            Problem.Text = " ";
            // 
            // AppointmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 93, 142);
            ClientSize = new Size(1045, 682);
            Controls.Add(Problem);
            Controls.Add(ID_Doctor);
            Controls.Add(DataTime);
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
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ID_Patient);
            Controls.Add(label1);
            Controls.Add(AllAppointment);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AppointmentForm";
            Text = "AppointmentForm";
            Load += AppointmentForm_Load;
            MouseMove += AppointmentForm_MouseMove;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)AllAppointment).EndInit();
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
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox ID_Patient;
        private Label label1;
        private DataGridView AllAppointment;
        private MaskedTextBox DataTime;
        private TextBox ID_Doctor;
        private TextBox Problem;
    }
}