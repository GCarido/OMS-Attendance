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
    public partial class Employee : Form
    {
        string dataInfo = "server=localhost;"
                        + "password=Admin1234-;"
                        + "user=root;"
                        + "database=employee;"
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
            Sqlcon.ConnectionString = dataInfo;
            Sqlcon.Open();
            Sqlcmd.Connection = Sqlcon;
            Sqlcmd.CommandText = "SELECT * FROM employee.employeerec " +
                "ORDER BY R0WS, Full_Name;";
            sqlrd = Sqlcmd.ExecuteReader();
            sqldt.Load(sqlrd);
            sqlrd.Close();
            Sqlcon.Close();
            dgv1.DataSource = sqldt;
        }
        public Employee()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name, id, contact, age, city, post, desig, dep, pass;
            name = nametxt.Text;
            id = idtxt.Text;
            contact = contactxt.Text;
            age = agetxt.Text;
            city = citytxt.Text;
            post = postaltxt.Text;
            desig = desgntxt.Text;
            dep = deptxt.Text;
            pass = gentxt.Text;

            if (name == "" || id == "" || contact == "" || age == "" || city == "" || post == "" || desig == "" ||
                  dep == "" || pass == "")
            {
                MessageBox.Show("All fields must be filled up.", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("The following information above will be added to the database. Do you want to continue?",
                           "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // Database
                    Sqlcon.ConnectionString = dataInfo;
                    Sqlcon.Open();
                    try
                    {
                        sqlQuery = ($"INSERT INTO employeerec(Full_Name, Pass, ID, Contact, Age, City, Postal, Designation, Department) VALUES('{nametxt.Text}', '{gentxt.Text}', '{idtxt.Text}' ,'{contactxt.Text}', '{agetxt.Text}', '{citytxt.Text}', '{postaltxt.Text}', '{desgntxt.Text}', '{deptxt.Text}');");
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
                }
                else { }
            }
        }

        private void modfbtn_Click(object sender, EventArgs e)
        {
            string name, id, contact, age, city, post, desig, dep, pass;
            name = nametxt.Text;
            id = idtxt.Text;
            contact = contactxt.Text;
            age = agetxt.Text;
            city = citytxt.Text;
            post = postaltxt.Text;
            desig = desgntxt.Text;
            dep = deptxt.Text;
            pass = gentxt.Text;
            if (name == "" || id == "" || contact == "" || age == "" || city == "" || post == "" || desig == "" ||
                  dep == "" || pass == "")
            {
                MessageBox.Show("Please enter all the fields to modify.","NOTICE",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else if (delrec.Text == "N/A" || delrec.Text == "")
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
                    sqlcmd.CommandText = "UPDATE employee.employeerec SET Full_Name = @Full_Name, Pass = @Pass, ID = @ID, Contact = @Contact, Age = @Age, City = @City, Postal = @Postal, Designation = @Designation, Department = @Department WHERE R0WS = @R0WS;";
                    sqlcmd.CommandType = CommandType.Text;
                    sqlcmd.Parameters.AddWithValue("@R0WS", delrec.Text);
                    sqlcmd.Parameters.AddWithValue("@Full_Name", nametxt.Text);
                    sqlcmd.Parameters.AddWithValue("@Pass", gentxt.Text);
                    sqlcmd.Parameters.AddWithValue("@ID", idtxt.Text);
                    sqlcmd.Parameters.AddWithValue("@Contact", contactxt.Text);
                    sqlcmd.Parameters.AddWithValue("@Age", agetxt.Text);
                    sqlcmd.Parameters.AddWithValue("@City", citytxt.Text);
                    sqlcmd.Parameters.AddWithValue("@Postal", postaltxt.Text);
                    sqlcmd.Parameters.AddWithValue("@Designation", desgntxt.Text);
                    sqlcmd.Parameters.AddWithValue("@Department", deptxt.Text);
                    sqlcmd.ExecuteNonQuery();
                    Sqlcon.Close();
                    UploadData();
                    delrec.Text = "";
                    searchbtn.PerformClick();
                    MessageBox.Show("The attendance record has been successfully modified.");
                }
            }
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("All fields will be cleared. Do you want to continue?",
                         "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                nametxt.Text = "";
                idtxt.Text = "";
                contactxt.Text = "";
                agetxt.Text = "";
                citytxt.Text = "";
                postaltxt.Text = "";
                desgntxt.Text = "";
                deptxt.Text = "";
                gentxt.Text = "";
                searchtxt.Text = "";
                MessageBox.Show("Fields cleared successfully");
            }
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            if (delrec.Text == "N/A" || delrec.Text == "")
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
                    sqlcmd.CommandText = "DELETE FROM employee.employeerec " +
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

                    Dashboard db = (Dashboard)Application.OpenForms["Dashboard"];
                    db.embtn.PerformClick();
                    MessageBox.Show("Record has been successfully deleted.");
                }
            }
        }

        private void genpass_Click(object sender, EventArgs e)
        {
            int len = 8;
            const string ValidChar = "abcdefghijklmnopqrstuvwxyzABCDEFG" +
                "HIJKLMNOPQRSTUVWXYZ0123456789";
            StringBuilder res = new StringBuilder();
            Random rand = new Random();
            while(0 < len--)
            {
                res.Append(ValidChar[rand.Next(ValidChar.Length)]);
            }
            gentxt.Text = res.ToString();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            UploadData();
        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                nametxt.Text = dgv1.SelectedRows[0].Cells[1].Value.ToString();
                gentxt.Text = dgv1.SelectedRows[0].Cells[2].Value.ToString();
                idtxt.Text = dgv1.SelectedRows[0].Cells[3].Value.ToString();
                contactxt.Text = dgv1.SelectedRows[0].Cells[4].Value.ToString();
                agetxt.Text = dgv1.SelectedRows[0].Cells[5].Value.ToString();
                citytxt.Text = dgv1.SelectedRows[0].Cells[6].Value.ToString();
                postaltxt.Text = dgv1.SelectedRows[0].Cells[7].Value.ToString();
                desgntxt.Text = dgv1.SelectedRows[0].Cells[8].Value.ToString();
                deptxt.Text = dgv1.SelectedRows[0].Cells[9].Value.ToString();
                delrec.Text = dgv1.SelectedRows[0].Cells[0].Value.ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Select the left most column of " +
                    "the specific row you wish to select " +
                    "record.", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                using (DataTable dtable = new DataTable("Full_Name"))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM employee.employeerec WHERE Full_Name LIKE @Full_Name OR Pass = @Pass OR ID = @ID OR Contact = @Contact OR Age = @Age OR City LIKE @City OR Postal LIKE @Postal OR Designation LIKE @Designation OR Department = @Department ORDER BY R0WS, Full_Name;", Sqlcon))
                    {
                        cmd.Parameters.AddWithValue("Full_Name", string.Format("%{0}%",
                            searchtxt.Text));
                        //cmd.Parameters.AddWithValue("Pass", string.Format("%{0}%",
                        //   searchtxt.Text));
                        // cmd.Parameters.AddWithValue("ID", string.Format("%{0}%",
                        //    searchtxt.Text));
                        //cmd.Parameters.AddWithValue("Contact", string.Format("%{0}%",
                         // searchtxt.Text));
                        cmd.Parameters.AddWithValue("Pass", searchtxt.Text);
                        cmd.Parameters.AddWithValue("ID", searchtxt.Text);
                        cmd.Parameters.AddWithValue("Age", searchtxt.Text);
                        cmd.Parameters.AddWithValue("Contact", searchtxt.Text);
                        //cmd.Parameters.AddWithValue("Age", string.Format("%{0}%",
                        //    searchtxt.Text));
                        cmd.Parameters.AddWithValue("City", string.Format("%{0}%",
                            searchtxt.Text));
                        cmd.Parameters.AddWithValue("Postal", string.Format("%{0}%",
                            searchtxt.Text));
                        cmd.Parameters.AddWithValue("Designation", string.Format("%{0}%",
                            searchtxt.Text));
                        cmd.Parameters.AddWithValue("Department", searchtxt.Text);
                        // cmd.Parameters.AddWithValue("Department", string.Format("%{0}%",
                        //     searchtxt.Text));

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
                        using (DataTable dtable = new DataTable("Employee Record"))
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
    }
}
