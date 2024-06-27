namespace School_Management_System
{
    partial class grades
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
            this.lblgroup = new System.Windows.Forms.Label();
            this.lblorder = new System.Windows.Forms.Label();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtorder = new System.Windows.Forms.TextBox();
            this.combgroup = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(30, 43);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(67, 13);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Grade Name";
            // 
            // lblgroup
            // 
            this.lblgroup.AutoSize = true;
            this.lblgroup.Location = new System.Drawing.Point(30, 81);
            this.lblgroup.Name = "lblgroup";
            this.lblgroup.Size = new System.Drawing.Size(68, 13);
            this.lblgroup.TabIndex = 0;
            this.lblgroup.Text = "Grade Group";
            // 
            // lblorder
            // 
            this.lblorder.AutoSize = true;
            this.lblorder.Location = new System.Drawing.Point(30, 121);
            this.lblorder.Name = "lblorder";
            this.lblorder.Size = new System.Drawing.Size(65, 13);
            this.lblorder.TabIndex = 0;
            this.lblorder.Text = "Grade Order";
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(7, 161);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(75, 23);
            this.btnsubmit.TabIndex = 1;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(128, 43);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(124, 20);
            this.txtname.TabIndex = 2;
            // 
            // txtorder
            // 
            this.txtorder.Location = new System.Drawing.Point(128, 121);
            this.txtorder.Name = "txtorder";
            this.txtorder.Size = new System.Drawing.Size(124, 20);
            this.txtorder.TabIndex = 2;
            // 
            // combgroup
            // 
            this.combgroup.FormattingEnabled = true;
            this.combgroup.Location = new System.Drawing.Point(128, 78);
            this.combgroup.Name = "combgroup";
            this.combgroup.Size = new System.Drawing.Size(124, 21);
            this.combgroup.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(198, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(315, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(699, 202);
            this.dataGridView1.TabIndex = 4;
            // 
            // grades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 235);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.combgroup);
            this.Controls.Add(this.txtorder);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.lblorder);
            this.Controls.Add(this.lblgroup);
            this.Controls.Add(this.lblname);
            this.Name = "grades";
            this.Text = "grades";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblgroup;
        private System.Windows.Forms.Label lblorder;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtorder;
        private System.Windows.Forms.ComboBox combgroup;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}