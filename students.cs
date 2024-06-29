using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Net;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace School_Management_System
{
    public partial class students : Form
    {
        //string conString = ConfigurationSettings.AppSettings["connectionString"];

            bool isEditMode = false;
            int editStudentId = 0;

            DataTable dt = new DataTable();
            DataView dv = new DataView();

            string admission = null;
            string firstname = null;
            string lastname = null;
            string fullname = null;
            string gender = null;
            string dob = null;
            string nic = null;
            string tp = null;
            string grid = null;
            string medium = null;
            string doa = null;
            string address = null;
        public students(/*string firstname, string lastname, string fullname, string gender, string dob, string nic, string tp, string grid, string medium, string doa, string address*/)
        {
            InitializeComponent();

            //this.firstname = firstname;
            //this.lastname = lastname;
            //this.fullname = fullname;
            //this.gender = gender;
            //this.dob = dob;
            //this.nic = nic;
            //this.tp = tp;
            //this.grid = grid;
            //this.medium = medium;
            //this.doa = doa;
            //this.address = address;
        }
        private void students_Load(object sender, EventArgs e)
        {
            txtad.Text = this.admission;
            txtfirst.Text = this.firstname;
            txtlast.Text = this.lastname;
            txtfull.Text = this.fullname;
            //dateTimePicker1.Value = DateTime.Parse(this.dob);
            txtNIC.Text = this.nic;
            txtTp.Text = this.tp;
            combGID.Text = this.grid;
            combmedium.Text = this.medium;
            //dateTimePicker2.Value = DateTime.Parse(this.doa);
            txtRadd.Text = this.address;

            if (this.gender == "Male")
            {
                rdmale.Checked = true;
            }
            else if (this.gender == "Female")
            {
                rdfemale.Checked = true;
            }
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            connetionString = "Data Source=RushanthG\\SQLEXPRESS;Initial Catalog=School Management System;User ID=sa;Password=4158;TrustServerCertificate=True";
            string gender = rdmale.Checked ? "Male" : (rdfemale.Checked ? "Female" : "");


            SqlConnection cnn = new SqlConnection(connetionString);
            SqlCommand command;
            string sql = "INSERT INTO [students] (admission_no,first_name, last_name, full_name, gender, date_of_birth, student_nic_no, tp_no, grade_id, medium, date_of_admission, resident_address) " +
             "VALUES ('" + txtad.Text + "','" + txtfirst.Text + "', '" + txtlast.Text + "', '" + txtfull.Text + "', '" + gender + "', '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "', '" +
             txtNIC.Text + "', '" + txtTp.Text + "', '" + combGID.Text + "', '" + combmedium.Text + "', '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "', '" + txtRadd.Text + "')";

            try
            {
                cnn.Open();
                command = new SqlCommand(sql, cnn);
                command.ExecuteNonQuery();
                command.Dispose();
                cnn.Close();
                MessageBox.Show("Successfully Created!", "create", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.Message);
            }
        }
        private void btnDisplay_Click_1(object sender, EventArgs e)
        {
            string connectionString = "Data Source=RushanthG\\SQLEXPRESS;Initial Catalog=School Management System;User ID=sa;Password=4158;TrustServerCertificate=True";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string sql = "SELECT * FROM [students]";
                    SqlCommand command = new SqlCommand(sql, con);

                    con.Open();
                    SqlDataReader sqlReader = command.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(sqlReader);

                    dataGridView1.DataSource = dt;

                    sqlReader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connectionString = null;
            connectionString = "Data Source=RushanthG\\SQLEXPRESS;Initial Catalog=School Management System;User ID=sa;Password=4158;TrustServerCertificate=True";
            string gender = rdmale.Checked ? "Male" : (rdfemale.Checked ? "Female" : "");

            SqlConnection cnn = new SqlConnection(connectionString);
            SqlCommand command;
            string sql = "UPDATE [students] SET " +
                          "admission_no = '" + txtad.Text + "',"+
                         "first_name = '" + txtfirst.Text + "', " +
                         "last_name = '" + txtlast.Text + "', " +
                         "full_name = '" + txtfull.Text + "', " +
                         "gender = '" + gender + "', " +
                         "date_of_birth = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "', " +
                         "tp_no = '" + txtTp.Text + "', " +
                         "grade_id = '" + combGID.Text + "', " +
                         "medium = '" + combmedium.Text + "', " +
                         "date_of_admission = '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "', " +
                         "resident_address = '" + txtRadd.Text + "' " +
                         "WHERE student_nic_no = '" + txtNIC.Text + "'";

            try
            {
                cnn.Open();
                command = new SqlCommand(sql, cnn);
                command.ExecuteNonQuery();
                command.Dispose();
                cnn.Close();
                MessageBox.Show("Successfully Updated!", "update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection! " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var cellValue = dataGridView1.SelectedRows[0].Cells[0].Value;
                if (cellValue != null && int.TryParse(cellValue.ToString(), out int studentId))
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this student record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string connectionString = "Data Source=RushanthG\\SQLEXPRESS;Initial Catalog=School Management System;User ID=sa;Password=4158;TrustServerCertificate=True";
                        using (SqlConnection con = new SqlConnection(connectionString))
                        {
                            SqlCommand cmd = new SqlCommand("DELETE FROM students WHERE id = @id", con);
                            cmd.Parameters.AddWithValue("@id", studentId);
                            try
                            {
                                con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();
                                MessageBox.Show("Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            catch (Exception ex)
                            {
                                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid student ID. Please select a valid row.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=RushanthG\\SQLEXPRESS;Initial Catalog=School Management System;User ID=sa;Password=4158;TrustServerCertificate=True";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string sql = "SELECT * FROM [students]";
                    SqlCommand command = new SqlCommand(sql, con);

                    con.Open();
                    SqlDataReader sqlReader = command.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(sqlReader);

                    dataGridView1.DataSource = dt;

                    sqlReader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string admission_no = dataGridView1.SelectedRows[0].Cells["admission_no"].Value.ToString();
                string first_name = dataGridView1.SelectedRows[0].Cells["first_name"].Value.ToString();
                string last_name = dataGridView1.SelectedRows[0].Cells["last_name"].Value.ToString();
                string full_name = dataGridView1.SelectedRows[0].Cells["full_name"].Value.ToString();
                string date_of_birth = dataGridView1.SelectedRows[0].Cells["date_of_birth"].Value.ToString();
                string student_nic_no = dataGridView1.SelectedRows[0].Cells["student_nic_no"].Value.ToString();
                string tp_no = dataGridView1.SelectedRows[0].Cells["tp_no"].Value.ToString();
                string grade_id = dataGridView1.SelectedRows[0].Cells["grade_id"].Value.ToString();
                string medium = dataGridView1.SelectedRows[0].Cells["medium"].Value.ToString();
                string date_of_admission = dataGridView1.SelectedRows[0].Cells["date_of_admission"].Value.ToString();
                string resident_address = dataGridView1.SelectedRows[0].Cells["resident_address"].Value.ToString();
                string gender = dataGridView1.SelectedRows[0].Cells["gender"].Value.ToString();

                txtad.Text = admission_no;
                txtfirst.Text = first_name;
                txtlast.Text = last_name;
                txtfull.Text = full_name;
                dateTimePicker1.Value = DateTime.Parse(date_of_birth);
                txtNIC.Text = student_nic_no;
                txtTp.Text = tp_no;
                combGID.Text = grade_id;
                combmedium.Text = medium;
                dateTimePicker2.Value = DateTime.Parse(date_of_admission);
                txtRadd.Text = resident_address;

                if (gender == "Male")
                {
                    rdmale.Checked = true;
                }
                else if (gender == "Female")
                {
                    rdfemale.Checked = true;
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}