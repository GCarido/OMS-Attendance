using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Organization_Management_System
{
    public partial class Form1 : Form
    {
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static string primkey  { get; set; }
        string dataInfo = "server=localhost;"
                         + "password=Admin1234-;"
                         + "user=root;"
                         + "database=employee;"
                         + "port=3306;";
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
       
        private void loginbtn_Click(object sender, EventArgs e)
        {
            String Full_Name, Pass, adminuser, adminpass;
            adminuser = "admin";
            adminpass = "1234";
            Full_Name = usern.Text;
            Pass = passw.Text;
            MySqlConnection conn = new MySqlConnection(dataInfo);
            String querry = ($"SELECT * FROM employee.employeerec WHERE Full_Name = '{usern.Text}' AND Pass = '{passw.Text}'");
            MySqlDataAdapter sda = new MySqlDataAdapter(querry, conn);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);
            if (usern.Text == "" || passw.Text == "")
            {
                MessageBox.Show("Please enter all the required field.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (usern.Text == adminuser && passw.Text == adminpass)
            {
                Username = usern.Text;
                Password = passw.Text;
                this.Hide();
                Dashboard d1 = new Dashboard();
                d1.ShowDialog();
            }
            else if (dtable.Rows.Count > 0)
            {
                Username = usern.Text;
                Password = passw.Text;
                Full_Name = usern.Text;
                Pass = passw.Text;
                this.Hide();
                Dashboard d1 = new Dashboard();
                d1.ShowDialog();
            }
            else
            {
                MessageBox.Show("The username or password is incorrect.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("All fields will be cleared. Do you want to continue?",
                           "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                usern.Text = "";
                passw.Text = "";
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void passw_TextChanged(object sender, EventArgs e)
        {
            passw.UseSystemPasswordChar = true;
        }

        private void paneldrg_MouseDown(object sender, MouseEventArgs e)
        {
            // Being able to drag the form (needed for title bar removal)
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
