using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class subjects : Form
    {
        DataTable dt = new DataTable();
        string connetionString = "Data Source=RushanthG\\SQLEXPRESS;Initial Catalog=School Management System;User ID=sa;Password=4158;TrustServerCertificate=True";

        public subjects()
        {
            InitializeComponent();
            InitializeEmptyDataGridView(); // Initialize the DataGridView with an empty DataTable
        }

        private void InitializeEmptyDataGridView()
        {
            dt.Columns.Add("id");
            dt.Columns.Add("subject_name");
            dt.Columns.Add("subject_index");
            dt.Columns.Add("subject_number");
            dt.Columns.Add("subject_order");
            dt.Columns.Add("created_at");
            dt.Columns.Add("updated_at");
            dt.Columns.Add("deleted_at");

            dataGridSub.DataSource = dt;
            dataGridSub.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Set selection mode to FullRowSelect
        }
        private void FetchSubjects()
        {
            string sql = "SELECT * FROM subjects";

            using (SqlConnection connection = new SqlConnection(connetionString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                try
                {
                    connection.Open();
                    SqlDataReader sqlDataReader = command.ExecuteReader();
                    dt.Load(sqlDataReader); // Load data into the existing DataTable
                    sqlDataReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching subjects: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ClearFields()
        {
            txtname.Text = "";
            txtindex.Text = "";
            txtnumber.Text = "";
            txtorder.Text = "";
        }
        private void btnGetAll_Click(object sender, EventArgs e)
        {
            dt.Clear(); // Clear the DataTable before loading new data
            FetchSubjects();
        }
        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            }

            string subject_name = txtname.Text;
            string subject_index = txtindex.Text;
            int subject_number = Convert.ToInt32(txtnumber.Text);
            int subject_order = Convert.ToInt32(txtorder.Text);

            // Check if subject already exists
            if (SubjectExists(subject_name, subject_index, subject_number, subject_order))
            {
                MessageBox.Show("A subject with the same details already exists.Please select Clear button and try again.", "Subject Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            InsertNewSubject(subject_name, subject_index, subject_number, subject_order);
        }
        private void InsertNewSubject(string subject_name, string subject_index, int subject_number, int subject_order)
        {
            string sql = "INSERT INTO subjects (subject_name, subject_index, subject_number, subject_order, created_at, updated_at) " +
                         "VALUES (@subject_name, @subject_index, @subject_number, @subject_order, GETDATE(), GETDATE())";

            using (SqlConnection con = new SqlConnection(connetionString))
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@subject_name", subject_name);
                cmd.Parameters.AddWithValue("@subject_index", subject_index);
                cmd.Parameters.AddWithValue("@subject_number", subject_number);
                cmd.Parameters.AddWithValue("@subject_order", subject_order);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    ClearFields();
                    FetchSubjects(); // Update the DataGridView immediately
                    MessageBox.Show("Subject inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inserting subject: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridSub.SelectedRows.Count > 0)
            {
                if (ValidateInputs())
                {
                    UpdateSelectedSubject();
                }
                else
                {
                    MessageBox.Show("Please correct the input values before updating.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select a subject to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void UpdateSelectedSubject()
        {
            string selectedSubjectId = dataGridSub.CurrentRow.Cells["id"].Value.ToString();

            string sql = "UPDATE subjects SET subject_name = @subject_name, subject_index = @subject_index, " +
                         "subject_number = @subject_number, subject_order = @subject_order, updated_at = GETDATE() " +
                         "WHERE id = @id";

            using (SqlConnection cnn = new SqlConnection(connetionString))
            using (SqlCommand command = new SqlCommand(sql, cnn))
            {
                command.Parameters.AddWithValue("@subject_name", txtname.Text);
                command.Parameters.AddWithValue("@subject_index", txtindex.Text);
                command.Parameters.AddWithValue("@subject_number", txtnumber.Text);
                command.Parameters.AddWithValue("@subject_order", txtorder.Text);
                command.Parameters.AddWithValue("@id", selectedSubjectId);

                try
                {
                    cnn.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Subject updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cnn.Close();
                    ClearFields();
                    btnGetAll_Click(null, null); // Reload subjects to reflect changes
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating subject: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dataGridSub.SelectedRows.Count > 0)
            {
                DeleteSelectedSubject();
            }
            else
            {
                MessageBox.Show("Please select a raw to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void DeleteSelectedSubject()
        {
            string selectedSubjectId = dataGridSub.CurrentRow.Cells["id"].Value.ToString();

            DialogResult result = MessageBox.Show("Are you sure you want to delete this raw?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string sql = "DELETE FROM subjects WHERE id = @id";

                using (SqlConnection cnn = new SqlConnection(connetionString))
                using (SqlCommand command = new SqlCommand(sql, cnn))
                {
                    command.Parameters.AddWithValue("@id", selectedSubjectId);

                    try
                    {
                        cnn.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Subject deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cnn.Close();
                        btnGetAll_Click(null, null); // Reload subjects to reflect changes
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting subject: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtname.Text))
            {
                MessageBox.Show("Please enter a subject name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtindex.Text))
            {
                MessageBox.Show("Please enter a subject index.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtnumber.Text))
            {
                MessageBox.Show("Please enter a subject number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtorder.Text))
            {
                MessageBox.Show("Please enter a subject order.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtorder.Text, out _))
            {
                MessageBox.Show("Subject order must be a valid integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        private bool SubjectExists(string subject_name, string subject_index, int subject_number, int subject_order)
        {
            string sql = "SELECT COUNT(*) FROM subjects WHERE subject_name = @subject_name AND subject_index = @subject_index " +
                         "AND subject_number = @subject_number AND subject_order = @subject_order";

            using (SqlConnection connection = new SqlConnection(connetionString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@subject_name", subject_name);
                command.Parameters.AddWithValue("@subject_index", subject_index);
                command.Parameters.AddWithValue("@subject_number", subject_number);
                command.Parameters.AddWithValue("@subject_order", subject_order);

                connection.Open();
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }
        private void dataGridSub_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridSub.SelectedRows.Count > 0)
            {
                txtname.Text = dataGridSub.SelectedRows[0].Cells["subject_name"].Value?.ToString() ?? "";
                txtindex.Text = dataGridSub.SelectedRows[0].Cells["subject_index"].Value?.ToString() ?? "";
                txtnumber.Text = dataGridSub.SelectedRows[0].Cells["subject_number"].Value?.ToString() ?? "";
                txtorder.Text = dataGridSub.SelectedRows[0].Cells["subject_order"].Value?.ToString() ?? "";
            }
        }
    }
}
