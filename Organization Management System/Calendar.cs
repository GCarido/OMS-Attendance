using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organization_Management_System
{
    public partial class Calendar : Form
    {
        public Calendar()
        {
            InitializeComponent();
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            // set file filter of dialog   
            dlg.FileName = "holidays.pdf";
            if (dlg.FileName != null)
            {
                  
                axAcroPDF1.LoadFile(dlg.FileName);
            }
        }
    }
}
