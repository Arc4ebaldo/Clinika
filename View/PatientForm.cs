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
    public partial class PatientForm : Form
    {
        public PatientForm()
        {
            InitializeComponent();
        }

        private PatientService patientService = new();
        private string ID;

        private void PatientForm_Load(object sender, EventArgs e)
        {
            List<Kostil> list = new List<Kostil>();
            foreach (var i in patientService.GetAllPatients()) {
                list.Add(new Kostil(
                    i.Id,
                    i.FirstName,
                    i.LastName,
                    i.BirthDay,
                    i.Adress,
                    i.PhoneNumber
                    ));
            }
            AllPatient.DataSource = list;
            AllPatient.AutoGenerateColumns = false;
            AllPatient.Columns["IDPole"].DataPropertyName = "Id";
            AllPatient.Columns["NamePole"].DataPropertyName = "FirstName";
            AllPatient.Columns["LastNamePole"].DataPropertyName = "LastName";
            AllPatient.Columns["BirthdayPole"].DataPropertyName = "BirthDay";
            AllPatient.Columns["NumberPole"].DataPropertyName = "PhoneNumber";
            AllPatient.Columns["EmailPole"].DataPropertyName = "Adress";
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

        private void PatientForm_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            PatientDTO newPatient = new PatientDTO(
                First_Name.Text,
                Last_Name.Text,
                Birthday.Text,
                Number.Text,
                Email.Text,
                null
             );
            patientService.CreatePatient(newPatient);
            List<Kostil> list = new List<Kostil>();
            foreach (var i in patientService.GetAllPatients())
            {
                list.Add(new Kostil(
                    i.Id,
                    i.FirstName,
                    i.LastName,
                    i.BirthDay,
                    i.Adress,
                    i.PhoneNumber
                    ));
            }
            AllPatient.DataSource = list;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            patientService.DeletePatientById(int.Parse(ID));
            List<Kostil> list = new List<Kostil>();
            foreach (var i in patientService.GetAllPatients())
            {
                list.Add(new Kostil(
                    i.Id,
                    i.FirstName,
                    i.LastName,
                    i.BirthDay,
                    i.Adress,
                    i.PhoneNumber
                    ));
            }
            AllPatient.DataSource = list;
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            PatientDTO newPatient = new PatientDTO(
                ID,
                First_Name.Text,
                Last_Name.Text,
                Birthday.Text,
                Number.Text,
                Email.Text,
                null
             );
            patientService.UpdatePatient(newPatient);
            List<Kostil> list = new List<Kostil>();
            foreach (var i in patientService.GetAllPatients())
            {
                list.Add(new Kostil(
                    i.Id,
                    i.FirstName,
                    i.LastName,
                    i.BirthDay,
                    i.Adress,
                    i.PhoneNumber
                    ));
            }
            AllPatient.DataSource = list;
        }

        private void AllPatient_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewSelectedCellCollection selectedCells = AllPatient.SelectedCells;
            ID = selectedCells[0].Value.ToString();
            First_Name.Text = selectedCells[1].Value.ToString();
            Last_Name.Text = (selectedCells[2].Value.ToString());
            Birthday.Text = selectedCells[3].Value.ToString();
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
