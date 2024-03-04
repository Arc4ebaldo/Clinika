using Clinica.DTO;
using Clinica.Models;
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
    public partial class AppointmentForm : Form
    {
        public AppointmentForm()
        {
            InitializeComponent();
        }

        private AppointmentService appointmentService = new();
        private string ID;

        private void AppointmentForm_Load(object sender, EventArgs e)
        {
            AllAppointment.AutoGenerateColumns = false;
            AllAppointment.DataSource = appointmentService.GetAllAppointment();
            AllAppointment.Columns["IDPole"].DataPropertyName = "Id";
            AllAppointment.Columns["DataPole"].DataPropertyName = "DataTime";
            AllAppointment.Columns["PatientNamePole"].DataPropertyName = "PatientFirstName";
            AllAppointment.Columns["PatientLastNamePole"].DataPropertyName = "PatientLastName";
            AllAppointment.Columns["DoctorNamePole"].DataPropertyName = "DoctorFirstName";
            AllAppointment.Columns["DoctorLastNamePole"].DataPropertyName = "DoctorLastName";
            AllAppointment.Columns["ProblemPole"].DataPropertyName = "Description";
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

        private void AppointmentForm_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void AddBtn_Click(object sender, EventArgs e)
        {
            string[] Fio_Patient = ID_Patient.Text.Split(" ");
            string[] Fio_Doctor = ID_Doctor.Text.Split(" ");


            AppointmentDTO newAppoint = new AppointmentDTO(
                    DataTime.Text,
                    Fio_Patient[0],
                    Fio_Patient[1],
                    Fio_Doctor[0],
                    Fio_Doctor[1],
                    Problem.Text
                );
            appointmentService.CreateAppointment(newAppoint);
            AllAppointment.DataSource = appointmentService.GetAllAppointment();

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            appointmentService.DeleteAppointmentById(int.Parse(ID));
            AllAppointment.DataSource = appointmentService.GetAllAppointment();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            string[] Fio_Patient = ID_Patient.Text.Split(" ");
            string[] Fio_Doctor = ID_Doctor.Text.Split(" ");

            AppointmentDTO newAppoint = new AppointmentDTO(
                ID,
                DataTime.Text,
                Fio_Patient[0],
                Fio_Patient[1],
                Fio_Doctor[0],
                Fio_Doctor[1],
                Problem.Text
             );
            appointmentService.UpdateAppointment(newAppoint);
            AllAppointment.DataSource = appointmentService.GetAllAppointment();
        }

        private void AllAppointment_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string[] Fio_Patient = ID_Patient.Text.Split(" ");
            string[] Fio_Doctor = ID_Doctor.Text.Split(" ");

            DataGridViewSelectedCellCollection selectedCells = AllAppointment.SelectedCells;
            ID = selectedCells[0].Value.ToString();
            DataTime.Text = selectedCells[1].Value.ToString();
            ID_Patient.Text = selectedCells[2].Value.ToString() + " " + selectedCells[3].Value.ToString();
            ID_Doctor.Text = selectedCells[4].Value.ToString() + " " + selectedCells[5].Value.ToString();
            Problem.Text = selectedCells[6].Value.ToString();
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

        private void FindBtn_Click(object sender, EventArgs e)
        {
            List<AppointmentDTO?> appointmentList = appointmentService.GetAllAppointment();
            string[] Fio_Patient = ID_Patient.Text.Split(" ");
            foreach (var i in appointmentList)
            {
                if (i.PatientFirstName == Fio_Patient[0] && i.PatientLastName == Fio_Patient[1])
                {
                    AllAppointment.DataSource = new List<AppointmentDTO>() { i };
                    return;
                }
            }
        }
    }
}
