namespace School_Management_System
{
    partial class Dashboard
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
            this.txtHeading = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtHeading
            // 
            this.txtHeading.BackColor = System.Drawing.Color.Teal;
            this.txtHeading.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeading.ForeColor = System.Drawing.Color.White;
            this.txtHeading.Location = new System.Drawing.Point(137, 12);
            this.txtHeading.Multiline = true;
            this.txtHeading.Name = "txtHeading";
            this.txtHeading.Size = new System.Drawing.Size(524, 59);
            this.txtHeading.TabIndex = 4;
            this.txtHeading.Text = "School Management System";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtHeading);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHeading;
    }
}