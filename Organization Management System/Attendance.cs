using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ClosedXML.Excel;
using System.Windows.Forms;

namespace Organization_Management_System
{
    public partial class Attendance : Form
    {
        public static string clockin { get; set; }
        public static string logdate { get; set; }
        string dataInfo = "server=localhost;"
                         + "password=Admin1234-;"
                         + "user=root;"
                         + "database=attendance;"
                         + "port=3306;";
        MySqlConnection Sqlcon = new MySqlConnection();
        MySqlCommand Sqlcmd = new MySqlCommand();
        DataTable sqldt = new DataTable();
        String sqlQuery;
        MySqlDataAdapter sqldta = new MySqlDataAdapter();
        MySqlDataReader sqlrd;
        DataSet ds = new DataSet();
        private void UploadData()
        {
            if (Form1.Username == "admin" && Form1.Password == "1234")
            {
                Sqlcon.ConnectionString = dataInfo;
                Sqlcon.Open();
                Sqlcmd.Connection = Sqlcon;
                Sqlcmd.CommandText = "SELECT * FROM attendance.attendancerec ORDER BY R0WS, Full_Name;";
                sqlrd = Sqlcmd.ExecuteReader();
                sqldt.Load(sqlrd);
                sqlrd.Close();
                Sqlcon.Close();
                dgv1.DataSource = sqldt;
            }
            else
            {
                Sqlcon.ConnectionString = dataInfo;
                Sqlcon.Open();
                Sqlcmd.Connection = Sqlcon;
                Sqlcmd.CommandText = ($"SELECT * FROM attendancerec WHERE Full_Name = '{Form1.Username}';");
                sqlrd = Sqlcmd.ExecuteReader();
                sqldt.Load(sqlrd);
                sqlrd.Close();
                Sqlcon.Close();
                dgv1.DataSource = sqldt;
            }
        }
        public Attendance()
        {
            InitializeComponent();
        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            timer1.Start();
            UploadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(dataInfo);
            string hm, sec, t, mm, dd, yy;
            if (MessageBox.Show("Your clock-in will be recorded. Do you want to continue?",
               "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                timer2.Interval = 5000;
                timer2.Tick += timer2_Tick;
                timer2.Start();
                timeinbtn.Enabled = false;
                hm = DateTime.Now.ToString("H:mm");
                sec = DateTime.Now.ToString("ss");
                t = DateTime.Now.ToString("tt");
                mm = DateTime.Now.ToString("MM");
                dd = DateTime.Now.ToString("dd");
                yy = DateTime.Now.ToString("yyyy");
                // Database
                String querry = ($"SELECT * FROM attendance.attendancerec WHERE Full_Name = '{Form1.Username}' AND Login_Date = '{dd}/{mm}/{yy}'");
                MySqlDataAdapter sda = new MySqlDataAdapter(querry, conn);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                if (dtable.Rows.Count > 0)
                {
                    MessageBox.Show("You may only time-in once per day.", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
             { 
                Sqlcon.ConnectionString = dataInfo;
                Sqlcon.Open();
                try
                {
                    sqlQuery = ($"INSERT INTO attendancerec(Full_Name, Clock_in, Clock_out, Login_Date, Total_Hours) VALUES('{Form1.Username}', '{hm}', '', '{dd}/{mm}/{yy}', 'NULL');");
                    Sqlcmd = new MySqlCommand(sqlQuery, Sqlcon);
                    sqlrd = Sqlcmd.ExecuteReader();
                    Sqlcon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Sqlcon.Close();
                }
                UploadData();
                MessageBox.Show("Your clock-in attendance has been successfully recorded.");
            }
            }
            else { }
        
        }

        private void timeoutbtn_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(dataInfo);
            string hm, sec, t, mm, dd, yy, sub;

            if (delrec.Text == "" || delrec.Text == "ROW")
            {
                MessageBox.Show("Please select a record for clock-out.", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("Your clock-out will be recorded. Do you want to continue?",
                    "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    timer3.Interval = 5000;
                    timer3.Tick += timer3_Tick;
                    timer3.Start();
                    timeoutbtn.Enabled = false;
                    hm = DateTime.Now.ToString("H:mm");
                    sec = DateTime.Now.ToString("ss");
                    t = DateTime.Now.ToString("tt");
                    mm = DateTime.Now.ToString("MM");
                    dd = DateTime.Now.ToString("dd");
                    yy = DateTime.Now.ToString("yyyy");
                    // Database
                    //String querry = ($"SELECT * FROM attendance.attendancerec WHERE Full_Name = '{Form1.Username}' AND Clock_in != '' AND Clock_out != '' AND Login_Date != '{dd}/{mm}/{yy}'");
                     String querry = ($"SELECT * FROM attendance.attendancerec WHERE Full_Name = '{Form1.Username}'");
                    //String querry = ($"SELECT * FROM attendance.attendancerec WHERE Clock_out != '' AND Login_Date != '{dd}/{mm}/{yy}'");
                    //String querry = ($"SELECT * FROM attendance.attendancerec WHERE Full_Name = '{Form1.Username}' AND Total_Hours != 'NULL'");
                    MySqlDataAdapter sda = new MySqlDataAdapter(querry, conn);
                    DataTable dtable = new DataTable();
                    sda.Fill(dtable);
                    if (dtable.Rows.Count > 0)
                    {
                        Sqlcon.ConnectionString = dataInfo;
                        Sqlcon.Open();
                        try
                        {
                            double hrs = Convert.ToDateTime($"{dd}/{mm}/{yy} {hm}").Subtract(Convert.ToDateTime($"{logdate} {clockin}")).TotalHours;
                            //sqlQuery = ($"INSERT INTO attendancerec(Full_Name, Clock_in, Clock_out, Login_Date) VALUES('{Form1.Username}', '', '{hm}:{sec} {t}' ,'{mm} {dd}, {yy}');");
                            //double minutes = Convert.ToDateTime("21/07/2022 18:09").Subtract(Convert.ToDateTime("21/07/2022 17:06")).TotalMinutes;
                            if (hrs < 10) // 10 hours limit for time-in and time-out
                            {
                                sqlQuery = ($"UPDATE attendance.attendancerec SET Clock_out = '{hm}', Total_Hours = '{hrs.ToString("0")}' WHERE R0WS = {delrec.Text};");
                                Sqlcmd = new MySqlCommand(sqlQuery, Sqlcon);
                                sqlrd = Sqlcmd.ExecuteReader();
                                Sqlcon.Close();
                                MessageBox.Show("Your clock-out attendance has been successfully recorded.");
                            }
                            else
                            {
                                MessageBox.Show("You cannot edit this record anymore.", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            Sqlcon.Close();
                        }

                        UploadData();
                       
                    }
                    else
                    {
                       MessageBox.Show("You may only select your own record and clock-in/clock-out once per day.", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    }
                }
                else { }
            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            try
            {
               // if (Sqlcon.State == ConnectionState.Closed)
                //{
                    Sqlcon.ConnectionString = dataInfo;
                    Sqlcon.Open();
                //}
                    using (DataTable dtable = new DataTable(""))
                    {
                        using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM attendance.attendancerec WHERE Full_Name LIKE @Full_Name OR Clock_in LIKE @Clock_in OR Clock_out LIKE @Clock_out OR Login_Date LIKE @Login_Date OR Total_Hours LIKE @Total_Hours ORDER BY R0WS, Full_Name;", Sqlcon))
                        {
                            cmd.Parameters.AddWithValue("Full_Name", string.Format("%{0}%",
                                searchtxt.Text));
                            cmd.Parameters.AddWithValue("Clock_in", string.Format("%{0}%",
                                searchtxt.Text));
                            cmd.Parameters.AddWithValue("Clock_out", string.Format("%{0}%",
                                searchtxt.Text));
                            cmd.Parameters.AddWithValue("Login_Date", string.Format("%{0}%",
                                searchtxt.Text));
                            cmd.Parameters.AddWithValue("Total_Hours", string.Format("%{0}%",
                                searchtxt.Text));
                            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                            adapter.Fill(dtable);
                            dgv1.DataSource = dtable;
                        }
                        Sqlcon.Close();
                    }
    
            }
            catch (Exception ex)
            { }
        }

        private void modfbtn_Click(object sender, EventArgs e)
        {
            if (Form1.Username == "admin" && Form1.Password == "1234")
            {
                if (modtxt.Text == "")
                {
                    MessageBox.Show("Please enter something to modify.","NOTICE",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else if (delrec.Text == "ROW" || delrec.Text == "")
                {
                    MessageBox.Show("Please select a row to modify.", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (MessageBox.Show("The record will be modified. Do you want to continue?",
                                "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Sqlcon.ConnectionString = dataInfo;
                        Sqlcon.Open();
                        MySqlCommand sqlcmd = new MySqlCommand();
                        sqlcmd.Connection = Sqlcon;
                        sqlcmd.CommandText = "UPDATE attendance.attendancerec SET Full_Name = @Full_Name WHERE R0WS = @R0WS;";
                        sqlcmd.CommandType = CommandType.Text;
                        sqlcmd.Parameters.AddWithValue("@R0WS", delrec.Text);
                        sqlcmd.Parameters.AddWithValue("@Full_Name", modtxt.Text);
                        sqlcmd.ExecuteNonQuery();
                        Sqlcon.Close();
                        UploadData();
                        delrec.Text = "";
                        searchbtn.PerformClick();
                        MessageBox.Show("The attendance record has been successfully modified.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Access denied. Only the administrator can access this button.", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            if (Form1.Username == "admin" && Form1.Password == "1234")
            {
                if (delrec.Text == "ROW" || delrec.Text == "")
                {
                    MessageBox.Show("Please select a row to delete.", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (MessageBox.Show("The record will be deleted. Do you want to continue?",
                                           "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Sqlcon.ConnectionString = dataInfo;
                        Sqlcon.Open();
                        MySqlCommand sqlcmd = new MySqlCommand();
                        sqlcmd.Connection = Sqlcon;
                        sqlcmd.CommandText = "DELETE FROM attendance.attendancerec " +
                            "WHERE R0WS = @R0WS;";
                        sqlcmd.CommandType = CommandType.Text;
                        sqlcmd.Parameters.AddWithValue("@R0WS", delrec.Text);
                        sqlcmd.ExecuteNonQuery();
                        Sqlcon.Close();
                        foreach (DataGridViewRow item in this.dgv1.SelectedRows)
                        {
                            dgv1.Rows.RemoveAt(item.Index);
                        }
                        UploadData();
                        delrec.Text = "";
                        searchbtn.PerformClick();
                        Dashboard db = (Dashboard)Application.OpenForms["Dashboard"];
                        db.ambtn.PerformClick();
                        MessageBox.Show("Record has been successfully deleted.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Access denied. Only the administrator can access this button.", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void searchtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string tt;
            minhlbl.Text = DateTime.Now.ToString("hh:mm");
            seclbl.Text = DateTime.Now.ToString("ss");
            tt = DateTime.Now.ToString("tt");
            if (tt == "AM")
            {
                ampmlbl.ForeColor = Color.Yellow;
            }
            else if (tt == "PM")
            {
                ampmlbl2.ForeColor = Color.Yellow;
            }
            else
            {
                ampmlbl.ForeColor = Color.FromArgb(200, 200, 200);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
          timer2.Stop();
          timeinbtn.Enabled = true;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
           timer3.Stop();
           timeoutbtn.Enabled = true;
        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string t_hours, logd, valid;
            try
            {
                valid = dgv1.SelectedRows[0].Cells[1].Value.ToString();
                if (Form1.Username == "admin")
                {
                    t_hours = dgv1.SelectedRows[0].Cells[2].Value.ToString();
                    clockin = t_hours;
                    logd = dgv1.SelectedRows[0].Cells[4].Value.ToString();
                    logdate = logd;
                    delrec.Text = dgv1.SelectedRows[0].Cells[0].Value.ToString();
                }
                else
                {
                    if (valid == Form1.Username)
                    {
                        t_hours = dgv1.SelectedRows[0].Cells[2].Value.ToString();
                        clockin = t_hours;
                        logd = dgv1.SelectedRows[0].Cells[4].Value.ToString();
                        logdate = logd;
                        delrec.Text = dgv1.SelectedRows[0].Cells[0].Value.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Please select your own record.", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Select the left most column of " +
                    "the specific row you wish to select " +
                    "record.", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exportbtn_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog save = new SaveFileDialog()
            {
                Filter = "Excel " +
               "Workbook|*.xlsx"
            })
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (DataTable dtable = new DataTable("Attendance Record"))
                        {
                            using (XLWorkbook wb = new XLWorkbook())
                            {
                                wb.Worksheets.Add(this.sqldt);
                                wb.SaveAs(save.FileName);
                            }
                        }
                        MessageBox.Show("You have successfully exported the " +
                            "database table", "NOTICE", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
