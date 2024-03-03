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
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
        }

        private DiseaseService diseaseService = new();
        private string ID;

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            AllHistory.DataSource = diseaseService.GetAllDiseases();
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

        private void HistoryForm_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string[] Fio_Patient = ID_Patient.Text.Split(' ');

            DiseaseDTO newDisease = new DiseaseDTO(
                Fio_Patient[0],
                Fio_Patient[1],
                startDay.Text,
                stopDay.Text,
                Diagnosis.Text,
                Medicines.Text
              );
            diseaseService.CreateDisease(newDisease);
            AllHistory.DataSource = diseaseService.GetAllDiseases();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            diseaseService.DeleteDiseaseById(int.Parse(ID));
            AllHistory.DataSource = diseaseService.GetAllDiseases();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            string[] Fio_Patient = ID_Patient.Text.Split(' ');

            DiseaseDTO newDisease = new DiseaseDTO(
                Fio_Patient[0],
                Fio_Patient[1],
                startDay.Text,
                stopDay.Text,
                Diagnosis.Text,
                Medicines.Text
           );
                diseaseService.UpdateDisease(newDisease);
                AllHistory.DataSource = diseaseService.GetAllDiseases();
        }

        private void AllHistory_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string[] Fio_Patient = ID_Patient.Text.Split(' ');

            DataGridViewSelectedCellCollection selectedCells = AllHistory.SelectedCells;
            Fio_Patient[0] = selectedCells[0].Value.ToString();
            Fio_Patient[1] = selectedCells[1].Value.ToString();
            startDay.Text = selectedCells[2].Value.ToString();
            stopDay.Text = selectedCells[3].Value.ToString();
            Diagnosis.Text = selectedCells[4].Value.ToString();
            Medicines.Text = selectedCells[5].Value.ToString();
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
