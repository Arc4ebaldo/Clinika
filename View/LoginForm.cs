using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clinica.View;

namespace Clinica
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Login_Enter(object sender, EventArgs e)
        {
            if (Login.Text == "ÀŒ√»Õ")
            {
                Login.Text = "";
                Login.ForeColor = Color.LightGray;
            }
        }

        private void Login_Leave(object sender, EventArgs e)
        {
            if (Login.Text == "")
            {
                Login.Text = "ÀŒ√»Õ";
                Login.ForeColor = Color.DimGray;
            }
        }

        private void Password_Enter(object sender, EventArgs e)
        {
            if (Password.Text == "œ¿–ŒÀ‹")
            {
                Password.Text = "";
                Password.ForeColor = Color.LightGray;
            }
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            if (Password.Text == "")
            {
                Password.Text = "œ¿–ŒÀ‹";
                Password.ForeColor = Color.DimGray;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void LogBtn_Click(object sender, EventArgs e)
        {
            if (!true)
            {
                MessageBox.Show("¬‚Â‰ÂÌ ÌÂ‚ÂÌ˚È ÎÓ„ËÌ/Ô‡ÓÎ¸");
            }
            else
            {
                MenuForm m = new MenuForm();
                m.Show();
                this.Hide();
            }
        }
    }
}
