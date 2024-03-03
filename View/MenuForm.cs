using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica.View
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void patientBtn_Click(object sender, EventArgs e)
        {
            PatientForm m = new PatientForm();
            m.Show();
            this.Close();
        }

        private void doctorBtn_Click(object sender, EventArgs e)
        {
            DoctorForm m = new DoctorForm();
            m.Show();
            this.Close();
        }

        private void apoointmentBtn_Click(object sender, EventArgs e)
        {
            AppointmentForm m = new AppointmentForm();
            m.Show();
            this.Close();
        }

        private void serviceBtn_Click(object sender, EventArgs e)
        {
            ServiceForm m = new ServiceForm();
            m.Show();
            this.Close();
        }

        private void historyBtn_Click(object sender, EventArgs e)
        {
            HistoryForm m = new HistoryForm();
            m.Show();
            this.Close();
        }
    }
}
