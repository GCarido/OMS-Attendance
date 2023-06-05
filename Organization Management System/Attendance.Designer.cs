namespace Organization_Management_System
{
    partial class Attendance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timeinbtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ampmlbl2 = new System.Windows.Forms.Label();
            this.ampmlbl = new System.Windows.Forms.Label();
            this.seclbl = new System.Windows.Forms.Label();
            this.minhlbl = new System.Windows.Forms.Label();
            this.timeoutbtn = new System.Windows.Forms.Button();
            this.searchbtn = new System.Windows.Forms.Button();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.modfbtn = new System.Windows.Forms.Button();
            this.delbtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.modtxt = new System.Windows.Forms.TextBox();
            this.delrec = new System.Windows.Forms.Label();
            this.exportbtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timeinbtn
            // 
            this.timeinbtn.BackColor = System.Drawing.Color.Khaki;
            this.timeinbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.timeinbtn.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeinbtn.ForeColor = System.Drawing.Color.Blue;
            this.timeinbtn.Location = new System.Drawing.Point(157, 193);
            this.timeinbtn.Name = "timeinbtn";
            this.timeinbtn.Size = new System.Drawing.Size(140, 46);
            this.timeinbtn.TabIndex = 1;
            this.timeinbtn.Text = "Clock-in";
            this.timeinbtn.UseVisualStyleBackColor = false;
            this.timeinbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(631, 126);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(22)))), ((int)(((byte)(32)))));
            this.panel3.Controls.Add(this.ampmlbl2);
            this.panel3.Controls.Add(this.ampmlbl);
            this.panel3.Controls.Add(this.seclbl);
            this.panel3.Controls.Add(this.minhlbl);
            this.panel3.Location = new System.Drawing.Point(157, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(329, 111);
            this.panel3.TabIndex = 4;
            // 
            // ampmlbl2
            // 
            this.ampmlbl2.AutoSize = true;
            this.ampmlbl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(22)))), ((int)(((byte)(32)))));
            this.ampmlbl2.Font = new System.Drawing.Font("Myanmar Text", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ampmlbl2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ampmlbl2.Location = new System.Drawing.Point(248, 54);
            this.ampmlbl2.Name = "ampmlbl2";
            this.ampmlbl2.Size = new System.Drawing.Size(82, 65);
            this.ampmlbl2.TabIndex = 4;
            this.ampmlbl2.Text = "PM";
            // 
            // ampmlbl
            // 
            this.ampmlbl.AutoSize = true;
            this.ampmlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(22)))), ((int)(((byte)(32)))));
            this.ampmlbl.Font = new System.Drawing.Font("Myanmar Text", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ampmlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ampmlbl.Location = new System.Drawing.Point(246, 4);
            this.ampmlbl.Name = "ampmlbl";
            this.ampmlbl.Size = new System.Drawing.Size(85, 65);
            this.ampmlbl.TabIndex = 3;
            this.ampmlbl.Text = "AM";
            // 
            // seclbl
            // 
            this.seclbl.AutoSize = true;
            this.seclbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(22)))), ((int)(((byte)(32)))));
            this.seclbl.Font = new System.Drawing.Font("Myanmar Text", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seclbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.seclbl.Location = new System.Drawing.Point(182, 36);
            this.seclbl.Name = "seclbl";
            this.seclbl.Size = new System.Drawing.Size(0, 65);
            this.seclbl.TabIndex = 1;
            // 
            // minhlbl
            // 
            this.minhlbl.AutoSize = true;
            this.minhlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(22)))), ((int)(((byte)(32)))));
            this.minhlbl.Font = new System.Drawing.Font("Myanmar Text", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minhlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.minhlbl.Location = new System.Drawing.Point(12, 8);
            this.minhlbl.Name = "minhlbl";
            this.minhlbl.Size = new System.Drawing.Size(0, 113);
            this.minhlbl.TabIndex = 0;
            // 
            // timeoutbtn
            // 
            this.timeoutbtn.BackColor = System.Drawing.Color.Khaki;
            this.timeoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.timeoutbtn.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeoutbtn.ForeColor = System.Drawing.Color.Blue;
            this.timeoutbtn.Location = new System.Drawing.Point(437, 193);
            this.timeoutbtn.Name = "timeoutbtn";
            this.timeoutbtn.Size = new System.Drawing.Size(140, 46);
            this.timeoutbtn.TabIndex = 3;
            this.timeoutbtn.Text = "Clock-out";
            this.timeoutbtn.UseVisualStyleBackColor = false;
            this.timeoutbtn.Click += new System.EventHandler(this.timeoutbtn_Click);
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.Color.Khaki;
            this.searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchbtn.Location = new System.Drawing.Point(42, 330);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(55, 23);
            this.searchbtn.TabIndex = 4;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = false;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // searchtxt
            // 
            this.searchtxt.Location = new System.Drawing.Point(103, 333);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(134, 20);
            this.searchtxt.TabIndex = 5;
            this.searchtxt.TextChanged += new System.EventHandler(this.searchtxt_TextChanged);
            // 
            // modfbtn
            // 
            this.modfbtn.BackColor = System.Drawing.Color.Khaki;
            this.modfbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.modfbtn.Location = new System.Drawing.Point(243, 330);
            this.modfbtn.Name = "modfbtn";
            this.modfbtn.Size = new System.Drawing.Size(55, 23);
            this.modfbtn.TabIndex = 6;
            this.modfbtn.Text = "Modify";
            this.modfbtn.UseVisualStyleBackColor = false;
            this.modfbtn.Click += new System.EventHandler(this.modfbtn_Click);
            // 
            // delbtn
            // 
            this.delbtn.BackColor = System.Drawing.Color.Khaki;
            this.delbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delbtn.Location = new System.Drawing.Point(444, 330);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(55, 23);
            this.delbtn.TabIndex = 7;
            this.delbtn.Text = "Delete";
            this.delbtn.UseVisualStyleBackColor = false;
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(42, 360);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(543, 150);
            this.dgv1.TabIndex = 10;
            this.dgv1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellClick);
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick);
            // 
            // modtxt
            // 
            this.modtxt.Location = new System.Drawing.Point(304, 333);
            this.modtxt.Name = "modtxt";
            this.modtxt.Size = new System.Drawing.Size(134, 20);
            this.modtxt.TabIndex = 11;
            // 
            // delrec
            // 
            this.delrec.AutoSize = true;
            this.delrec.BackColor = System.Drawing.Color.Lime;
            this.delrec.Font = new System.Drawing.Font("Cascadia Code", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delrec.ForeColor = System.Drawing.Color.Blue;
            this.delrec.Location = new System.Drawing.Point(505, 331);
            this.delrec.Name = "delrec";
            this.delrec.Size = new System.Drawing.Size(36, 20);
            this.delrec.TabIndex = 12;
            this.delrec.Text = "ROW";
            // 
            // exportbtn
            // 
            this.exportbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.exportbtn.BackgroundImage = global::Organization_Management_System.Properties.Resources.icons8_export_30;
            this.exportbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exportbtn.Location = new System.Drawing.Point(555, 324);
            this.exportbtn.Name = "exportbtn";
            this.exportbtn.Size = new System.Drawing.Size(30, 30);
            this.exportbtn.TabIndex = 13;
            this.exportbtn.UseVisualStyleBackColor = false;
            this.exportbtn.Click += new System.EventHandler(this.exportbtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Organization_Management_System.Properties.Resources.icons8_meeting_time_100__1_;
            this.pictureBox2.Location = new System.Drawing.Point(315, 165);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(116, 99);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Organization_Management_System.Properties.Resources.icons8_meeting_time_100;
            this.pictureBox1.Location = new System.Drawing.Point(33, 165);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(631, 511);
            this.Controls.Add(this.exportbtn);
            this.Controls.Add(this.delrec);
            this.Controls.Add(this.modtxt);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.delbtn);
            this.Controls.Add(this.modfbtn);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.timeoutbtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.timeinbtn);
            this.Name = "Attendance";
            this.Text = "Attendance";
            this.Load += new System.EventHandler(this.Attendance_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button timeinbtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button timeoutbtn;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.Button modfbtn;
        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label ampmlbl;
        private System.Windows.Forms.Label seclbl;
        private System.Windows.Forms.Label minhlbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label ampmlbl2;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.TextBox modtxt;
        private System.Windows.Forms.Label delrec;
        private System.Windows.Forms.Button exportbtn;
    }
}