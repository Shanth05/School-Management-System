using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class student_subject : Form
    {
        string connectionString = "Data Source=RushanthG\\SQLEXPRESS;Initial Catalog=School Management System;User ID=sa;Password=4158;TrustServerCertificate=True";
        bool isEditMode = false;
        int editStudentSubjectId = 0;

        public student_subject()
        {
            InitializeComponent();
            LoadStudentData();
            LoadSubjectData();
            LoadStudentSubjectData();

            combSubid.SelectedIndex = -1;
            combAd.SelectedIndex = -1;
            dataGridView2.Visible = false;
            dataGridView2.CellClick += DataGridView2_CellClick;
        }

        private void DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView2.Rows[e.RowIndex].Selected = true;
            }
        }

        private void LoadStudentData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT id  FROM students", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                combSubid.DisplayMember = "student_name";
                combSubid.ValueMember = "id";
                combSubid.DataSource = dt;
                combSubid.SelectedIndex = -1;
            }
        }

        private void LoadSubjectData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT id  FROM subjects", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                combAd.DisplayMember = "subject_name";
                combAd.ValueMember = "id";
                combAd.DataSource = dt;
                combAd.SelectedIndex = -1;
            }
        }

        private void LoadStudentSubjectData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM student_subject", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView2.DataSource = dt;
            }
        }

        private void btnGettAll_Click(object sender, EventArgs e)
        {
            LoadStudentSubjectData();
            dataGridView2.Visible = true;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!isEditMode)
            {
                AddStudentSubject();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateStudentSubject();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteStudentSubject();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                editStudentSubjectId = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["id"].Value);
                LoadEditData(editStudentSubjectId);
                isEditMode = true;
            }
        }

        private void AddStudentSubject()
        {
            if (combSubid.SelectedItem == null || combAd.SelectedItem == null)
            {
                MessageBox.Show("Please select both Student ID and Subject ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sql = "INSERT INTO student_subject (student_id, subject_id) VALUES (@student_id, @subject_id)";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    int studentId = combSubid.SelectedValue == DBNull.Value ? -1 : (int)combSubid.SelectedValue;
                    int subjectId = combAd.SelectedValue == DBNull.Value ? -1 : (int)combAd.SelectedValue;

                    cmd.Parameters.AddWithValue("@student_id", studentId);
                    cmd.Parameters.AddWithValue("@subject_id", subjectId);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Inserted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetForm();
                        LoadStudentSubjectData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void DeleteStudentSubject()
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                var cellValue = dataGridView2.SelectedRows[0].Cells[0].Value;
                if (cellValue != null && int.TryParse(cellValue.ToString(), out int studentSubjectId))
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        using (SqlConnection con = new SqlConnection(connectionString))
                        {
                            SqlCommand cmd = new SqlCommand("DELETE FROM student_subject WHERE id = @id", con);
                            cmd.Parameters.AddWithValue("@id", studentSubjectId);
                            try
                            {
                                con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();

                                MessageBox.Show("Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadStudentSubjectData();
                                ResetForm();
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
                    MessageBox.Show("Invalid ID. Please select a valid row.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void LoadEditData(int studentSubjectId)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM student_subject WHERE id = @id", con);
                cmd.Parameters.AddWithValue("@id", studentSubjectId);
                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        combSubid.SelectedValue = reader["student_id"];
                        combAd.SelectedValue = reader["subject_id"];
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void UpdateStudentSubject()
        {
            if (combSubid.SelectedItem == null || combAd.SelectedItem == null)
            {
                MessageBox.Show("Please select both Student ID and Subject ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sql = "UPDATE student_subject SET student_id = @student_id, subject_id = @subject_id WHERE id = @id";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    int studentId = combSubid.SelectedValue == DBNull.Value ? -1 : (int)combSubid.SelectedValue;
                    int subjectId = combAd.SelectedValue == DBNull.Value ? -1 : (int)combAd.SelectedValue;

                    cmd.Parameters.AddWithValue("@student_id", studentId);
                    cmd.Parameters.AddWithValue("@subject_id", subjectId);
                    cmd.Parameters.AddWithValue("@id", editStudentSubjectId);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetForm();
                        LoadStudentSubjectData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ResetForm()
        {
            combSubid.SelectedIndex = -1;
            combAd.SelectedIndex = -1;
            isEditMode = false;
            btnCreate.Text = "Create";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
