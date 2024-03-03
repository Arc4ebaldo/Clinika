using Clinica.DTO;
using Clinica.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica.View
{
    public partial class DoctorForm : Form
    {
        public DoctorForm()
        {
            InitializeComponent();
        }

        private DoctorService doctorService = new();
        private string ID;

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            AllDoctor.DataSource = doctorService.GetAllDoctors();
            Role.DataSource = new List<string>() { };
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        int lx, ly;
        int sw, sh;
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MenuForm m = new MenuForm();
            m.Show();
            this.Close();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void DoctorForm_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            DoctorDTO newDoctor = new DoctorDTO(
                First_Name.Text,
                Last_Name.Text,
                Role.Text,
                Number.Text,
                Email.Text
                );
            doctorService.CreateDoctor(newDoctor);
            AllDoctor.DataSource = doctorService.GetAllDoctors();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            doctorService.DeleteDoctorById(int.Parse(ID));
            AllDoctor.DataSource = doctorService.GetAllDoctors();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            DoctorDTO newDoctor = new DoctorDTO(
                ID,
                First_Name.Text,
                Last_Name.Text,
                Role.Text,
                Number.Text,
                Email.Text
             );
                doctorService.UpdateDoctor(newDoctor);
                AllDoctor.DataSource = doctorService.GetAllDoctors();
        }

        private void AllDoctor_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewSelectedCellCollection selectedCells = AllDoctor.SelectedCells;
            ID = selectedCells[0].Value.ToString();
            First_Name.Text = selectedCells[1].Value.ToString();
            Last_Name.Text = selectedCells[2].Value.ToString();
            Role.Text = selectedCells[3].Value.ToString();
            Number.Text = selectedCells[4].Value.ToString();
            Email.Text = selectedCells[5].Value.ToString();
        }

        private string result = "";

        private void SealBtn_Click(object sender, EventArgs e)
        {
            result = "Строка 1\n\n";

            result += "Строка 2\nСтрока 3";

            // объект для печати
            PrintDocument printDocument = new PrintDocument();

            // обработчик события печати
            printDocument.PrintPage += PrintPageHandler;

            // диалог настройки печати
            PrintDialog printDialog = new PrintDialog();

            // установка объекта печати для его настройки
            printDialog.Document = printDocument;

            // если в диалоге было нажато ОК
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDialog.Document.Print(); // печатаем
        }

        void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(result, new Font("Arial", 14), Brushes.Black, 0, 0);
        }
    }
}
