using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class grade_subject : Form
    {
        string connectionString = "Data Source=RushanthG\\SQLEXPRESS;Initial Catalog=School Management System;User ID=sa;Password=4158;TrustServerCertificate=True";
        bool isEditMode = false;
        int editGradeSubjectId = 0;

        public grade_subject()
        {
            InitializeComponent();
            LoadGradeData();
            LoadSubjectData();
            LoadGradeSubjectData();

            combgrid.SelectedIndex = -1;
            combsubid.SelectedIndex = -1;
            dataGridView2.Visible = false;
            dataGridView2.CellClick += DataGridView2_CellClick;
        }

        private void DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the clicked cell is in a row (not header or elsewhere)
            if (e.RowIndex >= 0)
            {
                // Select the clicked row
                dataGridView2.Rows[e.RowIndex].Selected = true;
            }
        }

        private void LoadGradeData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT id, grade_name FROM grades", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                combgrid.DisplayMember = "grade_name";
                combgrid.ValueMember = "id";
                combgrid.DataSource = dt;
                combgrid.SelectedIndex = -1;
            }
        }

        private void LoadSubjectData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT id, subject_name FROM subjects", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                combsubid.DisplayMember = "subject_name";
                combsubid.ValueMember = "id";
                combsubid.DataSource = dt;
                combsubid.SelectedIndex = -1;
            }
        }

        private void LoadGradeSubjectData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM grade_subject", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView2.DataSource = dt;
            }
        }

        private void btnGettAll_Click(object sender, EventArgs e)
        {
            LoadGradeSubjectData();
            dataGridView2.Visible = true; // Show the DataGridView after loading data

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!isEditMode)
            {
                // Check if any row is selected in dataGridView2
                if (dataGridView2.SelectedRows.Count > 0)
                {
                    MessageBox.Show("Please select Clear button before insert.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                AddGradeSubject();
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
                UpdateGradeSubject();         
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteGradeSubject();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                editGradeSubjectId = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["id"].Value); // Assuming "id" is the column name in your DataGridView
                LoadEditData(editGradeSubjectId);
                isEditMode = true;
            }
        }

        private void AddGradeSubject()
        {
            if (combgrid.SelectedItem == null || combsubid.SelectedItem == null)
            {
                MessageBox.Show("Please select both Grade ID and Subject ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sql = "INSERT INTO grade_subject (grade_id, subject_id) VALUES (@grade_id, @subject_id)";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    // Check for DBNull.Value before casting
                    int gradeId = combgrid.SelectedValue == DBNull.Value ? -1 : (int)combgrid.SelectedValue;
                    int subjectId = combsubid.SelectedValue == DBNull.Value ? -1 : (int)combsubid.SelectedValue;

                    cmd.Parameters.AddWithValue("@grade_id", gradeId);
                    cmd.Parameters.AddWithValue("@subject_id", subjectId);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Inserted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetForm();
                        LoadGradeSubjectData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void DeleteGradeSubject()
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                var cellValue = dataGridView2.SelectedRows[0].Cells[0].Value;
                if (cellValue != null && int.TryParse(cellValue.ToString(), out int gradeSubjectId))
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        using (SqlConnection con = new SqlConnection(connectionString))
                        {
                            SqlCommand cmd = new SqlCommand("DELETE FROM grade_subject WHERE id = @id", con);
                            cmd.Parameters.AddWithValue("@id", gradeSubjectId);
                            try
                            {
                                con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();

                                MessageBox.Show("Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadGradeSubjectData();
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

        private void LoadEditData(int gradeSubjectId)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM grade_subject WHERE id = @id", con);
                cmd.Parameters.AddWithValue("@id", gradeSubjectId);
                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        combgrid.SelectedValue = reader["grade_id"];
                        combsubid.SelectedValue = reader["subject_id"];
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void UpdateGradeSubject()
        {
            if (combgrid.SelectedItem == null || combsubid.SelectedItem == null)
            {
                MessageBox.Show("Please select both Grade ID and Subject ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sql = "UPDATE grade_subject SET grade_id = @grade_id, subject_id = @subject_id WHERE id = @id";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    // Check for DBNull.Value before casting
                    int gradeId = combgrid.SelectedValue == DBNull.Value ? -1 : (int)combgrid.SelectedValue;
                    int subjectId = combsubid.SelectedValue == DBNull.Value ? -1 : (int)combsubid.SelectedValue;

                    cmd.Parameters.AddWithValue("@grade_id", gradeId);
                    cmd.Parameters.AddWithValue("@subject_id", subjectId);
                    cmd.Parameters.AddWithValue("@id", editGradeSubjectId);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetForm();
                        LoadGradeSubjectData();
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
            combgrid.SelectedIndex = -1;
            combsubid.SelectedIndex = -1;
            isEditMode = false;
            btnCreate.Text = "Create";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
