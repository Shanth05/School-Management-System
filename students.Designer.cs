namespace School_Management_System
{
    partial class students
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnshow = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtad = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.combmedium = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.combGID = new System.Windows.Forms.ComboBox();
            this.rdfemale = new System.Windows.Forms.RadioButton();
            this.rdmale = new System.Windows.Forms.RadioButton();
            this.txtRadd = new System.Windows.Forms.TextBox();
            this.txtTp = new System.Windows.Forms.TextBox();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.txtfull = new System.Windows.Forms.TextBox();
            this.txtlast = new System.Windows.Forms.TextBox();
            this.txtfirst = new System.Windows.Forms.TextBox();
            this.lblRadd = new System.Windows.Forms.Label();
            this.lblDOA = new System.Windows.Forms.Label();
            this.lblmedium = new System.Windows.Forms.Label();
            this.lblgid = new System.Windows.Forms.Label();
            this.lblTp = new System.Windows.Forms.Label();
            this.lblNIC = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lblfull = new System.Windows.Forms.Label();
            this.lblad = new System.Windows.Forms.Label();
            this.lbllast = new System.Windows.Forms.Label();
            this.lblfirst = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.SpringGreen;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(529, 372);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(101, 32);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightGreen;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(658, 374);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(101, 30);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(781, 374);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 30);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.LightGreen;
            this.btnDisplay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(1146, 479);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(101, 32);
            this.btnDisplay.TabIndex = 6;
            this.btnDisplay.Text = "Refresh";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(351, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(591, 347);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Red;
            this.btnexit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(1314, 479);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(101, 32);
            this.btnexit.TabIndex = 6;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnshow
            // 
            this.btnshow.BackColor = System.Drawing.Color.LightGreen;
            this.btnshow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshow.Location = new System.Drawing.Point(412, 372);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(101, 32);
            this.btnshow.TabIndex = 6;
            this.btnshow.Text = "Show";
            this.btnshow.UseVisualStyleBackColor = false;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtad);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.combmedium);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.combGID);
            this.panel1.Controls.Add(this.rdfemale);
            this.panel1.Controls.Add(this.rdmale);
            this.panel1.Controls.Add(this.txtRadd);
            this.panel1.Controls.Add(this.txtTp);
            this.panel1.Controls.Add(this.txtNIC);
            this.panel1.Controls.Add(this.txtfull);
            this.panel1.Controls.Add(this.txtlast);
            this.panel1.Controls.Add(this.txtfirst);
            this.panel1.Controls.Add(this.lblRadd);
            this.panel1.Controls.Add(this.lblDOA);
            this.panel1.Controls.Add(this.lblmedium);
            this.panel1.Controls.Add(this.lblgid);
            this.panel1.Controls.Add(this.lblTp);
            this.panel1.Controls.Add(this.lblNIC);
            this.panel1.Controls.Add(this.lblDOB);
            this.panel1.Controls.Add(this.lblgender);
            this.panel1.Controls.Add(this.lblfull);
            this.panel1.Controls.Add(this.lblad);
            this.panel1.Controls.Add(this.lbllast);
            this.panel1.Controls.Add(this.lblfirst);
            this.panel1.Location = new System.Drawing.Point(9, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 347);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(122, 18);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(200, 20);
            this.txtad.TabIndex = 58;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(124, 267);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 57;
            // 
            // combmedium
            // 
            this.combmedium.FormattingEnabled = true;
            this.combmedium.Items.AddRange(new object[] {
            "Tamil",
            "English",
            "Sinhala"});
            this.combmedium.Location = new System.Drawing.Point(122, 241);
            this.combmedium.Name = "combmedium";
            this.combmedium.Size = new System.Drawing.Size(200, 21);
            this.combmedium.TabIndex = 55;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "M-DD-YYYY";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(122, 140);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 56;
            // 
            // combGID
            // 
            this.combGID.FormattingEnabled = true;
            this.combGID.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "O/l",
            "A/l"});
            this.combGID.Location = new System.Drawing.Point(122, 215);
            this.combGID.Name = "combGID";
            this.combGID.Size = new System.Drawing.Size(200, 21);
            this.combGID.TabIndex = 54;
            // 
            // rdfemale
            // 
            this.rdfemale.AutoSize = true;
            this.rdfemale.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdfemale.Location = new System.Drawing.Point(179, 119);
            this.rdfemale.Name = "rdfemale";
            this.rdfemale.Size = new System.Drawing.Size(62, 17);
            this.rdfemale.TabIndex = 53;
            this.rdfemale.TabStop = true;
            this.rdfemale.Text = "Female";
            this.rdfemale.UseVisualStyleBackColor = true;
            // 
            // rdmale
            // 
            this.rdmale.AutoSize = true;
            this.rdmale.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdmale.Location = new System.Drawing.Point(122, 118);
            this.rdmale.Name = "rdmale";
            this.rdmale.Size = new System.Drawing.Size(51, 17);
            this.rdmale.TabIndex = 52;
            this.rdmale.TabStop = true;
            this.rdmale.Text = "Male";
            this.rdmale.UseVisualStyleBackColor = true;
            // 
            // txtRadd
            // 
            this.txtRadd.Location = new System.Drawing.Point(124, 292);
            this.txtRadd.Multiline = true;
            this.txtRadd.Name = "txtRadd";
            this.txtRadd.Size = new System.Drawing.Size(200, 64);
            this.txtRadd.TabIndex = 50;
            // 
            // txtTp
            // 
            this.txtTp.Location = new System.Drawing.Point(122, 190);
            this.txtTp.Name = "txtTp";
            this.txtTp.Size = new System.Drawing.Size(200, 20);
            this.txtTp.TabIndex = 49;
            // 
            // txtNIC
            // 
            this.txtNIC.Location = new System.Drawing.Point(122, 165);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(200, 20);
            this.txtNIC.TabIndex = 48;
            // 
            // txtfull
            // 
            this.txtfull.Location = new System.Drawing.Point(122, 93);
            this.txtfull.Name = "txtfull";
            this.txtfull.Size = new System.Drawing.Size(200, 20);
            this.txtfull.TabIndex = 47;
            // 
            // txtlast
            // 
            this.txtlast.Location = new System.Drawing.Point(122, 68);
            this.txtlast.Name = "txtlast";
            this.txtlast.Size = new System.Drawing.Size(200, 20);
            this.txtlast.TabIndex = 51;
            // 
            // txtfirst
            // 
            this.txtfirst.Location = new System.Drawing.Point(122, 43);
            this.txtfirst.Name = "txtfirst";
            this.txtfirst.Size = new System.Drawing.Size(200, 20);
            this.txtfirst.TabIndex = 46;
            // 
            // lblRadd
            // 
            this.lblRadd.AutoSize = true;
            this.lblRadd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRadd.Location = new System.Drawing.Point(3, 292);
            this.lblRadd.Name = "lblRadd";
            this.lblRadd.Size = new System.Drawing.Size(114, 17);
            this.lblRadd.TabIndex = 44;
            this.lblRadd.Text = "Resident Address";
            // 
            // lblDOA
            // 
            this.lblDOA.AutoSize = true;
            this.lblDOA.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOA.Location = new System.Drawing.Point(3, 267);
            this.lblDOA.Name = "lblDOA";
            this.lblDOA.Size = new System.Drawing.Size(123, 17);
            this.lblDOA.TabIndex = 43;
            this.lblDOA.Text = "Date of Admission";
            // 
            // lblmedium
            // 
            this.lblmedium.AutoSize = true;
            this.lblmedium.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmedium.Location = new System.Drawing.Point(3, 241);
            this.lblmedium.Name = "lblmedium";
            this.lblmedium.Size = new System.Drawing.Size(59, 17);
            this.lblmedium.TabIndex = 42;
            this.lblmedium.Text = "Medium";
            // 
            // lblgid
            // 
            this.lblgid.AutoSize = true;
            this.lblgid.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgid.Location = new System.Drawing.Point(3, 215);
            this.lblgid.Name = "lblgid";
            this.lblgid.Size = new System.Drawing.Size(62, 17);
            this.lblgid.TabIndex = 41;
            this.lblgid.Text = "Grade ID";
            // 
            // lblTp
            // 
            this.lblTp.AutoSize = true;
            this.lblTp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTp.Location = new System.Drawing.Point(3, 190);
            this.lblTp.Name = "lblTp";
            this.lblTp.Size = new System.Drawing.Size(94, 17);
            this.lblTp.TabIndex = 40;
            this.lblTp.Text = "Telephone No";
            // 
            // lblNIC
            // 
            this.lblNIC.AutoSize = true;
            this.lblNIC.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNIC.Location = new System.Drawing.Point(3, 168);
            this.lblNIC.Name = "lblNIC";
            this.lblNIC.Size = new System.Drawing.Size(104, 17);
            this.lblNIC.TabIndex = 39;
            this.lblNIC.Text = "Student NIC No";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(3, 140);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(88, 17);
            this.lblDOB.TabIndex = 38;
            this.lblDOB.Text = "Date of Birth";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.Location = new System.Drawing.Point(3, 117);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(52, 17);
            this.lblgender.TabIndex = 37;
            this.lblgender.Text = "Gender";
            // 
            // lblfull
            // 
            this.lblfull.AutoSize = true;
            this.lblfull.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfull.Location = new System.Drawing.Point(3, 93);
            this.lblfull.Name = "lblfull";
            this.lblfull.Size = new System.Drawing.Size(71, 17);
            this.lblfull.TabIndex = 36;
            this.lblfull.Text = "Full Name";
            // 
            // lblad
            // 
            this.lblad.AutoSize = true;
            this.lblad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblad.Location = new System.Drawing.Point(3, 18);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(73, 17);
            this.lblad.TabIndex = 35;
            this.lblad.Text = "Admission";
            // 
            // lbllast
            // 
            this.lbllast.AutoSize = true;
            this.lbllast.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllast.Location = new System.Drawing.Point(3, 68);
            this.lbllast.Name = "lbllast";
            this.lbllast.Size = new System.Drawing.Size(73, 17);
            this.lbllast.TabIndex = 45;
            this.lbllast.Text = "Last Name";
            // 
            // lblfirst
            // 
            this.lblfirst.AutoSize = true;
            this.lblfirst.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfirst.Location = new System.Drawing.Point(3, 43);
            this.lblfirst.Name = "lblfirst";
            this.lblfirst.Size = new System.Drawing.Size(75, 17);
            this.lblfirst.TabIndex = 34;
            this.lblfirst.Text = "First Name";
            // 
            // students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(953, 415);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Name = "students";
            this.Text = "students";
            this.Load += new System.EventHandler(this.students_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox combmedium;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox combGID;
        private System.Windows.Forms.RadioButton rdfemale;
        private System.Windows.Forms.RadioButton rdmale;
        private System.Windows.Forms.TextBox txtRadd;
        private System.Windows.Forms.TextBox txtTp;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.TextBox txtfull;
        private System.Windows.Forms.TextBox txtlast;
        private System.Windows.Forms.TextBox txtfirst;
        private System.Windows.Forms.Label lblRadd;
        private System.Windows.Forms.Label lblDOA;
        private System.Windows.Forms.Label lblmedium;
        private System.Windows.Forms.Label lblgid;
        private System.Windows.Forms.Label lblTp;
        private System.Windows.Forms.Label lblNIC;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lblfull;
        private System.Windows.Forms.Label lblad;
        private System.Windows.Forms.Label lbllast;
        private System.Windows.Forms.Label lblfirst;
    }
}