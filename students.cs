using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Net;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class students : Form
    {
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

        public students()
        {
            InitializeComponent();
        }

        private void students_Load(object sender, EventArgs e)
        {
            txtad.Text = this.admission;
            txtfirst.Text = this.firstname;
            txtlast.Text = this.lastname;
            txtfull.Text = this.fullname;
            txtNIC.Text = this.nic;
            txtTp.Text = this.tp;
            combGID.Text = this.grid;
            combmedium.Text = this.medium;
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

        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            string connetionString = "Data Source=RushanthG\\SQLEXPRESS;Initial Catalog=School Management System;User ID=sa;Password=4158;TrustServerCertificate=True";
            string gender = rdmale.Checked ? "Male" : (rdfemale.Checked ? "Female" : "");

            string sql = "INSERT INTO [students] (admission_no, first_name, last_name, full_name, gender, date_of_birth, student_nic_no, tp_no, grade_id, medium, date_of_admission, resident_address) " +
             "VALUES (@admission_no, @first_name, @last_name, @full_name, @gender, @date_of_birth, @student_nic_no, @tp_no, @grade_id, @medium, @date_of_admission, @resident_address)";

            using (SqlConnection cnn = new SqlConnection(connetionString))
            using (SqlCommand command = new SqlCommand(sql, cnn))
            {
                command.Parameters.AddWithValue("@admission_no", txtad.Text);
                command.Parameters.AddWithValue("@first_name", txtfirst.Text);
                command.Parameters.AddWithValue("@last_name", txtlast.Text);
                command.Parameters.AddWithValue("@full_name", txtfull.Text);
                command.Parameters.AddWithValue("@gender", gender);
                command.Parameters.AddWithValue("@date_of_birth", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@student_nic_no", txtNIC.Text);
                command.Parameters.AddWithValue("@tp_no", txtTp.Text);
                command.Parameters.AddWithValue("@grade_id", combGID.Text);
                command.Parameters.AddWithValue("@medium", combmedium.Text);
                command.Parameters.AddWithValue("@date_of_admission", dateTimePicker2.Value.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@resident_address", txtRadd.Text);

                try
                {
                    cnn.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Successfully Created!", "Create", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot open connection! " + ex.Message);
                }
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            string connectionString = "Data Source=RushanthG\\SQLEXPRESS;Initial Catalog=School Management System;User ID=sa;Password=4158;TrustServerCertificate=True";
            string gender = rdmale.Checked ? "Male" : (rdfemale.Checked ? "Female" : "");

            string sql = "UPDATE [students] SET " +
                          "admission_no = @admission_no, first_name = @first_name, last_name = @last_name, full_name = @full_name, gender = @gender, " +
                          "date_of_birth = @date_of_birth, tp_no = @tp_no, grade_id = @grade_id, medium = @medium, date_of_admission = @date_of_admission, " +
                          "resident_address = @resident_address WHERE student_nic_no = @student_nic_no";

            using (SqlConnection cnn = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(sql, cnn))
            {
                command.Parameters.AddWithValue("@admission_no", txtad.Text);
                command.Parameters.AddWithValue("@first_name", txtfirst.Text);
                command.Parameters.AddWithValue("@last_name", txtlast.Text);
                command.Parameters.AddWithValue("@full_name", txtfull.Text);
                command.Parameters.AddWithValue("@gender", gender);
                command.Parameters.AddWithValue("@date_of_birth", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@tp_no", txtTp.Text);
                command.Parameters.AddWithValue("@grade_id", combGID.Text);
                command.Parameters.AddWithValue("@medium", combmedium.Text);
                command.Parameters.AddWithValue("@date_of_admission", dateTimePicker2.Value.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@resident_address", txtRadd.Text);
                command.Parameters.AddWithValue("@student_nic_no", txtNIC.Text);

                try
                {
                    cnn.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Successfully Updated!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot open connection! " + ex.Message);
                }
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
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
                MessageBox.Show("Please select a row to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataView dv = new DataView();

            string connectionString = "Data Source=RushanthG\\SQLEXPRESS;Initial Catalog=School Management System;User ID=sa;Password=4158;TrustServerCertificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "Select * from students";

                try
                {
                    connection.Open();
                    SqlDataAdapter da = new SqlDataAdapter(sql, connection);
                    da.Fill(dt);

                    dv = dt.DefaultView;
                    dataGridView1.DataSource = dt; // Assign DataTable directly

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
