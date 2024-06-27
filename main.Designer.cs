namespace School_Management_System
{
    partial class main
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
            this.btnstudents = new System.Windows.Forms.Button();
            this.btnsubjects = new System.Windows.Forms.Button();
            this.btngrades = new System.Windows.Forms.Button();
            this.btnstudent_subject = new System.Windows.Forms.Button();
            this.btngrade_subject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnstudents
            // 
            this.btnstudents.Location = new System.Drawing.Point(55, 51);
            this.btnstudents.Name = "btnstudents";
            this.btnstudents.Size = new System.Drawing.Size(96, 42);
            this.btnstudents.TabIndex = 1;
            this.btnstudents.Text = "Students";
            this.btnstudents.UseVisualStyleBackColor = true;
            this.btnstudents.Click += new System.EventHandler(this.btnstudents_Click);
            // 
            // btnsubjects
            // 
            this.btnsubjects.Location = new System.Drawing.Point(55, 122);
            this.btnsubjects.Name = "btnsubjects";
            this.btnsubjects.Size = new System.Drawing.Size(96, 42);
            this.btnsubjects.TabIndex = 1;
            this.btnsubjects.Text = "Subjects";
            this.btnsubjects.UseVisualStyleBackColor = true;
            this.btnsubjects.Click += new System.EventHandler(this.btnsubjects_Click);
            // 
            // btngrades
            // 
            this.btngrades.Location = new System.Drawing.Point(55, 198);
            this.btngrades.Name = "btngrades";
            this.btngrades.Size = new System.Drawing.Size(96, 42);
            this.btngrades.TabIndex = 1;
            this.btngrades.Text = "Grades";
            this.btngrades.UseVisualStyleBackColor = true;
            this.btngrades.Click += new System.EventHandler(this.btngrades_Click);
            // 
            // btnstudent_subject
            // 
            this.btnstudent_subject.Location = new System.Drawing.Point(55, 257);
            this.btnstudent_subject.Name = "btnstudent_subject";
            this.btnstudent_subject.Size = new System.Drawing.Size(96, 42);
            this.btnstudent_subject.TabIndex = 1;
            this.btnstudent_subject.Text = "Student_Subject";
            this.btnstudent_subject.UseVisualStyleBackColor = true;
            this.btnstudent_subject.Click += new System.EventHandler(this.btnstudent_subject_Click);
            // 
            // btngrade_subject
            // 
            this.btngrade_subject.Location = new System.Drawing.Point(55, 329);
            this.btngrade_subject.Name = "btngrade_subject";
            this.btngrade_subject.Size = new System.Drawing.Size(96, 42);
            this.btngrade_subject.TabIndex = 1;
            this.btngrade_subject.Text = "Grade_Subject";
            this.btngrade_subject.UseVisualStyleBackColor = true;
            this.btngrade_subject.Click += new System.EventHandler(this.btngrade_subject_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 405);
            this.Controls.Add(this.btngrade_subject);
            this.Controls.Add(this.btnstudent_subject);
            this.Controls.Add(this.btngrades);
            this.Controls.Add(this.btnsubjects);
            this.Controls.Add(this.btnstudents);
            this.Name = "main";
            this.Text = "main";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnstudents;
        private System.Windows.Forms.Button btnsubjects;
        private System.Windows.Forms.Button btngrades;
        private System.Windows.Forms.Button btnstudent_subject;
        private System.Windows.Forms.Button btngrade_subject;
    }
}