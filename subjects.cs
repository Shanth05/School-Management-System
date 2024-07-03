using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class subjects : Form
    {
        DataTable dt = new DataTable();
        DataView dv = new DataView();

        // SQL Server connection string
        string connetionString = "Data Source=RushanthG\\SQLEXPRESS;Initial Catalog=School Management System;User ID=sa;Password=4158;TrustServerCertificate=True";

        public subjects()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO subjects (subject_name, subject_index, subject_number, subject_order) VALUES (@subject_name, @subject_index, @subject_number, @subject_order)";

            using (SqlConnection cnn = new SqlConnection(connetionString))
            using (SqlCommand command = new SqlCommand(sql, cnn))
            {
                command.Parameters.AddWithValue("@subject_name", txtname.Text);
                command.Parameters.AddWithValue("@subject_index", txtindex.Text);
                command.Parameters.AddWithValue("@subject_number", txtnumber.Text);
                command.Parameters.AddWithValue("@subject_order", txtorder.Text);

                try
                {
                    cnn.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cnn.Close();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving subject: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(connetionString);
            SqlCommand command;

            string sql = "SELECT * FROM subjects";
            try
            {
                con.Open();
                command = new SqlCommand(sql, con);
                SqlDataReader sqlReader = command.ExecuteReader();

                dt.Load(sqlReader);
                dv = dt.DefaultView;
                dataGridSub.DataSource = dv;

                sqlReader.Close();
                command.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading subjects: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridSub.SelectedRows.Count > 0)
            {
                string selectedSubjectId = dataGridSub.CurrentRow.Cells["id"].Value.ToString(); // Assuming "id" is the name of the column in your DataGridView

                string sql = "UPDATE subjects SET subject_name = @subject_name, subject_index = @subject_index, subject_number = @subject_number, subject_order = @subject_order WHERE id = @id";

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
                        MessageBox.Show("Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cnn.Close();
                        ClearFields(); // Clear input fields after successful update
                        btnshow_Click(sender, e); // Reload subjects to reflect changes
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating subject: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a subject to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridSub.SelectedRows.Count > 0)
            {
                string selectedSubjectId = dataGridSub.CurrentRow.Cells["id"].Value.ToString(); // Assuming "id" is the name of the column in your DataGridView

                DialogResult result = MessageBox.Show("Are you sure you want to delete this subject?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                            MessageBox.Show("Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cnn.Close();
                            btnshow_Click(sender, e); // Reload subjects to reflect changes
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error deleting subject: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a subject to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearFields()
        {
            txtname.Text = "";
            txtindex.Text = "";
            txtnumber.Text = "";
            txtorder.Text = "";
        }
    }
}
