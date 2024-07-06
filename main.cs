using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?","Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if(check == DialogResult.Yes)
            {
                Login frm = new Login();
                frm.ShowDialog();
                this.Hide();
            }                   
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
        }

        private void btnstudents_Click(object sender, EventArgs e)
        {
            
            students frm = new students();
            frm.ShowDialog();  
        }


        private void btnsubjects_Click(object sender, EventArgs e)
        {
            subjects frm = new subjects();
            frm.ShowDialog();
        }

        private void btngrades_Click(object sender, EventArgs e)
        {
            grades frm = new grades();
            frm.ShowDialog();
        }

        private void btnstusub_Click(object sender, EventArgs e)
        {
            student_subject frm = new student_subject();
            frm.ShowDialog();
        }

        private void btngrsub_Click(object sender, EventArgs e)
        {
            grade_subject frm = new grade_subject();
            frm.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
