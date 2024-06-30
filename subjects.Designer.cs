namespace School_Management_System
{
    partial class subjects
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
            this.lblname = new System.Windows.Forms.Label();
            this.lblindex = new System.Windows.Forms.Label();
            this.lblnumber = new System.Windows.Forms.Label();
            this.lblorder = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtindex = new System.Windows.Forms.TextBox();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.txtorder = new System.Windows.Forms.TextBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(42, 101);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(74, 13);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Subject Name";
            // 
            // lblindex
            // 
            this.lblindex.AutoSize = true;
            this.lblindex.Location = new System.Drawing.Point(42, 127);
            this.lblindex.Name = "lblindex";
            this.lblindex.Size = new System.Drawing.Size(72, 13);
            this.lblindex.TabIndex = 0;
            this.lblindex.Text = "Subject Index";
            // 
            // lblnumber
            // 
            this.lblnumber.AutoSize = true;
            this.lblnumber.Location = new System.Drawing.Point(42, 153);
            this.lblnumber.Name = "lblnumber";
            this.lblnumber.Size = new System.Drawing.Size(83, 13);
            this.lblnumber.TabIndex = 0;
            this.lblnumber.Text = "Subject Number";
            // 
            // lblorder
            // 
            this.lblorder.AutoSize = true;
            this.lblorder.Location = new System.Drawing.Point(42, 179);
            this.lblorder.Name = "lblorder";
            this.lblorder.Size = new System.Drawing.Size(72, 13);
            this.lblorder.TabIndex = 0;
            this.lblorder.Text = "Subject Order";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(133, 101);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(141, 20);
            this.txtname.TabIndex = 1;
            // 
            // txtindex
            // 
            this.txtindex.Location = new System.Drawing.Point(133, 127);
            this.txtindex.Name = "txtindex";
            this.txtindex.Size = new System.Drawing.Size(141, 20);
            this.txtindex.TabIndex = 1;
            // 
            // txtnumber
            // 
            this.txtnumber.Location = new System.Drawing.Point(133, 153);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(141, 20);
            this.txtnumber.TabIndex = 1;
            // 
            // txtorder
            // 
            this.txtorder.Location = new System.Drawing.Point(133, 179);
            this.txtorder.Name = "txtorder";
            this.txtorder.Size = new System.Drawing.Size(141, 20);
            this.txtorder.TabIndex = 1;
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(203, 206);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(71, 23);
            this.btnsubmit.TabIndex = 2;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(297, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(573, 259);
            this.dataGridView1.TabIndex = 3;
            // 
            // subjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 295);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.txtorder);
            this.Controls.Add(this.txtnumber);
            this.Controls.Add(this.txtindex);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblorder);
            this.Controls.Add(this.lblnumber);
            this.Controls.Add(this.lblindex);
            this.Controls.Add(this.lblname);
            this.Name = "subjects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "subjects";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblindex;
        private System.Windows.Forms.Label lblnumber;
        private System.Windows.Forms.Label lblorder;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtindex;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.TextBox txtorder;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}