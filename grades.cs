using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class grades : Form
    {
        private string connectionString = "Data Source=RushanthG\\SQLEXPRESS;Initial Catalog=School Management System;User ID=sa;Password=4158;TrustServerCertificate=True";

        public grades()
        {
            InitializeComponent();
            InitializeEmptyDataGridView();
        }

        private void InitializeEmptyDataGridView()
        {
            // Create an empty DataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("grade_name");
            dt.Columns.Add("grade_group");
            dt.Columns.Add("grade_order");
            dt.Columns.Add("created_at");
            dt.Columns.Add("updated_at");

            // Bind the empty DataTable to the DataGridView
            dataGridView2.DataSource = dt;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void FetchGrades()
        {
            string sql = "SELECT * FROM grades";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                try
                {
                    connection.Open();
                    SqlDataReader sqlDataReader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(sqlDataReader);
                    dataGridView2.DataSource = dt;
                    sqlDataReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching grades: " + ex.Message);
                }
            }
        }
        private void btnGettAll_Click(object sender, EventArgs e)
        {
            FetchGrades(); // Fetch and display grades on button click
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            string gradeName = txtname.Text;
            string gradeGroup = combGroup.SelectedItem.ToString();
            int gradeOrder = Convert.ToInt32(txtOrder.Text);

            InsertOrUpdateGrade(gradeName, gradeGroup, gradeOrder);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int id;
                if (int.TryParse(dataGridView2.CurrentRow.Cells["id"].Value.ToString(), out id))
                {
                    string gradeName = txtname.Text.Trim();
                    string gradeGroup = combGroup.SelectedItem?.ToString();
                    int gradeOrder;

                    // Check if any of the fields are unchanged
                    if (string.Equals(gradeName, dataGridView2.SelectedRows[0].Cells["grade_name"].Value.ToString(), StringComparison.InvariantCultureIgnoreCase)
                        && string.Equals(gradeGroup, dataGridView2.SelectedRows[0].Cells["grade_group"].Value.ToString(), StringComparison.InvariantCultureIgnoreCase)
                        && int.TryParse(txtOrder.Text, out gradeOrder) && gradeOrder == Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["grade_order"].Value))
                    {
                        MessageBox.Show("Please change at least one field (Grade Name, Group, or Order) before updating.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Validate inputs
                    if (string.IsNullOrWhiteSpace(gradeName) || string.IsNullOrWhiteSpace(gradeGroup) || string.IsNullOrWhiteSpace(txtOrder.Text))
                    {
                        MessageBox.Show("Grade Name, Grade Group, and Grade Order cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (!int.TryParse(txtOrder.Text, out gradeOrder))
                    {
                        MessageBox.Show("Grade Order must be a valid integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    InsertOrUpdateGrade(gradeName, gradeGroup, gradeOrder);
                }
                else
                {
                    MessageBox.Show("Invalid Grade ID format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a grade to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView2.CurrentRow.Cells["id"].Value);
                var confirmResult = MessageBox.Show("Are you sure to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    DeleteGrade(id);
                }
            }
            else
            {
                MessageBox.Show("Please select a grade to delete.");
            }
        }
        private void ClearFields()
        {
            txtname.Text = string.Empty;
            combGroup.SelectedIndex = -1; // Clear selected item in combGroup
            txtOrder.Text = string.Empty;
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtname.Text))
            {
                MessageBox.Show("Please enter a grade name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (combGroup.SelectedItem == null)
            {
                MessageBox.Show("Please select a grade group.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtOrder.Text))
            {
                MessageBox.Show("Please enter a grade order.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtOrder.Text, out _))
            {
                MessageBox.Show("Grade order must be a valid integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool GradeExists(string gradeName, string gradeGroup, int gradeOrder)
        {
            string sql = "SELECT COUNT(*) FROM grades WHERE grade_name = @grade_name AND grade_group = @grade_group AND grade_order = @grade_order";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@grade_name", gradeName);
                cmd.Parameters.AddWithValue("@grade_group", gradeGroup);
                cmd.Parameters.AddWithValue("@grade_order", gradeOrder);

                con.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        private void InsertOrUpdateGrade(string gradeName, string gradeGroup, int gradeOrder)
        {
            string insertSql = "INSERT INTO grades (grade_name, grade_group, grade_order, created_at, updated_at) " +
                               "VALUES (@grade_name, @grade_group, @grade_order, GETDATE(), GETDATE())";

            string updateSql = "UPDATE grades SET updated_at = GETDATE() WHERE grade_name = @grade_name AND grade_group = @grade_group AND grade_order = @grade_order";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    using (SqlCommand cmd = new SqlCommand(GradeExists(gradeName, gradeGroup, gradeOrder) ? updateSql : insertSql, con, transaction))
                    {
                        cmd.Parameters.AddWithValue("@grade_name", gradeName);
                        cmd.Parameters.AddWithValue("@grade_group", gradeGroup);
                        cmd.Parameters.AddWithValue("@grade_order", gradeOrder);

                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    ClearFields();
                    FetchGrades(); // Update the DataGridView immediately
                    MessageBox.Show("Grade saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error saving grade: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void DeleteGrade(int id)
        {
            string sql = "DELETE FROM grades WHERE id = @id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    FetchGrades(); // Update the DataGridView immediately
                    MessageBox.Show("Grade deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting grade: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView2_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                txtname.Text = dataGridView2.SelectedRows[0].Cells["grade_name"].Value.ToString();
                combGroup.SelectedItem = dataGridView2.SelectedRows[0].Cells["grade_group"].Value.ToString();
                txtOrder.Text = dataGridView2.SelectedRows[0].Cells["grade_order"].Value.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
