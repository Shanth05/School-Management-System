namespace School_Management_System
{
    partial class student_subject
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.combSubid = new System.Windows.Forms.ComboBox();
            this.combAd = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnGettAll = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblad = new System.Windows.Forms.Label();
            this.lblsub = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(766, 30);
            this.panel2.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(735, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(26, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Student And Subject Details";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(346, 71);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(414, 303);
            this.dataGridView2.TabIndex = 70;
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // txtsearch
            // 
            this.txtsearch.BackColor = System.Drawing.Color.Teal;
            this.txtsearch.Location = new System.Drawing.Point(346, 27);
            this.txtsearch.Multiline = true;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(414, 38);
            this.txtsearch.TabIndex = 73;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.combSubid);
            this.panel1.Controls.Add(this.combAd);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lblad);
            this.panel1.Controls.Add(this.lblsub);
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 338);
            this.panel1.TabIndex = 69;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::School_Management_System.Properties.Resources.Advantages_Of_School_Management_System_copy;
            this.pictureBox2.Location = new System.Drawing.Point(30, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(290, 108);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 65;
            this.pictureBox2.TabStop = false;
            // 
            // combSubid
            // 
            this.combSubid.FormattingEnabled = true;
            this.combSubid.Items.AddRange(new object[] {
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
            "11",
            "12"});
            this.combSubid.Location = new System.Drawing.Point(148, 166);
            this.combSubid.Name = "combSubid";
            this.combSubid.Size = new System.Drawing.Size(172, 21);
            this.combSubid.TabIndex = 64;
            // 
            // combAd
            // 
            this.combAd.FormattingEnabled = true;
            this.combAd.Items.AddRange(new object[] {
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
            "11",
            "12"});
            this.combAd.Location = new System.Drawing.Point(148, 205);
            this.combAd.Name = "combAd";
            this.combAd.Size = new System.Drawing.Size(172, 21);
            this.combAd.TabIndex = 64;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.SpringGreen;
            this.btnClear.FlatAppearance.BorderSize = 2;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(260, 232);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(77, 32);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Refresh";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.btnGettAll);
            this.panel3.Controls.Add(this.btnCreate);
            this.panel3.Location = new System.Drawing.Point(2, 296);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(335, 39);
            this.panel3.TabIndex = 12;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.BorderSize = 2;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(249, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(77, 32);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.SpringGreen;
            this.btnUpdate.FlatAppearance.BorderSize = 2;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(169, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(74, 32);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnGettAll
            // 
            this.btnGettAll.BackColor = System.Drawing.Color.SpringGreen;
            this.btnGettAll.FlatAppearance.BorderSize = 2;
            this.btnGettAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnGettAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnGettAll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGettAll.Location = new System.Drawing.Point(3, 4);
            this.btnGettAll.Name = "btnGettAll";
            this.btnGettAll.Size = new System.Drawing.Size(77, 32);
            this.btnGettAll.TabIndex = 10;
            this.btnGettAll.Text = "GetAll";
            this.btnGettAll.UseVisualStyleBackColor = false;
            this.btnGettAll.Click += new System.EventHandler(this.btnGettAll_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.SpringGreen;
            this.btnCreate.FlatAppearance.BorderSize = 2;
            this.btnCreate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(86, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(77, 32);
            this.btnCreate.TabIndex = 10;
            this.btnCreate.Text = "+New";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblad
            // 
            this.lblad.AutoSize = true;
            this.lblad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblad.Location = new System.Drawing.Point(13, 205);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(117, 21);
            this.lblad.TabIndex = 58;
            this.lblad.Text = "Admission No";
            // 
            // lblsub
            // 
            this.lblsub.AutoSize = true;
            this.lblsub.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsub.Location = new System.Drawing.Point(13, 166);
            this.lblsub.Name = "lblsub";
            this.lblsub.Size = new System.Drawing.Size(88, 21);
            this.lblsub.TabIndex = 59;
            this.lblsub.Text = "Subject ID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::School_Management_System.Properties.Resources.icons8_search_50;
            this.pictureBox1.Location = new System.Drawing.Point(726, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 15);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // student_subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 378);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.panel1);
            this.Name = "student_subject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "student_subject";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox combSubid;
        private System.Windows.Forms.ComboBox combAd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnGettAll;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblad;
        private System.Windows.Forms.Label lblsub;
    }
}