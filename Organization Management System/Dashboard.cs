using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Organization_Management_System
{
    public partial class Dashboard : Form
    {
        public static string AttendanceForm { get; set; }
        public static string EmployeeForm { get; set; }
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
           Application.Exit();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        
        private void paneldrg1_MouseDown(object sender, MouseEventArgs e)
        {
            // Being able to drag the form (needed for title bar removal)
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Attendance at = new Attendance();
            at.TopLevel = false;
            pnlform.Controls.Add(at);
            at.Dock = DockStyle.Fill;
            at.BringToFront();
            at.Show();
            at.FormBorderStyle = FormBorderStyle.None;
        }

        public void embtn_Click(object sender, EventArgs e)
        {
            if (Form1.Username == "admin" && Form1.Password == "1234")
            {
                Employee em = new Employee();
                em.TopLevel = false;
                pnlform.Controls.Add(em);
                em.Dock = DockStyle.Fill;
                em.BringToFront();
                em.Show();
                em.FormBorderStyle = FormBorderStyle.None;
            }
            else
            {
                MessageBox.Show("Access denied. Only the administrator can access this section.", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void rfcpbtn_Click(object sender, EventArgs e)
        {
            Calendar clndr = new Calendar();
            clndr.TopLevel = false;
            pnlform.Controls.Add(clndr);
            clndr.Dock = DockStyle.Fill;
            clndr.BringToFront();
            clndr.Show();
            clndr.FormBorderStyle = FormBorderStyle.None;
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.TopLevel = false;
            pnlform.Controls.Add(hm);
            hm.Dock = DockStyle.Fill;
            hm.BringToFront();
            hm.Show();
            hm.FormBorderStyle = FormBorderStyle.None;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
