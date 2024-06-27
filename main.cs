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

        private void btnstudent_subject_Click(object sender, EventArgs e)
        {
            student_subject frm = new student_subject();
            frm.ShowDialog();
        }

        private void btngrade_subject_Click(object sender, EventArgs e)
        {
            grade_student frm = new grade_student();
            frm.ShowDialog();
        }
    }
}
