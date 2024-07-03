using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class grades : Form
    {
        public grades()
        {
            InitializeComponent();
        }

        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            string sql = null;

            connetionString = "Data Source=RushanthG\\SQLEXPRESS;Initial Catalog=School Management System;User ID=sa;Password=4158;TrustServerCertificate=True";

            sql = "INSERT INTO grades (grade_name,grade_group,grade_order) VALUES ('" + txtname.Text + "','" + combGroup.Text + "','" + txtOrder.Text + "');";
            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
                MessageBox.Show("Save Successfully");
                txtname.Text = "";
                combGroup.Text = "";
                txtOrder.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataView dv = new DataView();

            string connetionString = null;
            string sql = null;

            connetionString = "Data Source=RushanthG\\SQLEXPRESS;Initial Catalog=School Management System;User ID=sa;Password=4158;TrustServerCertificate=True";
            SqlConnection cnn;
            cnn = new SqlConnection(connetionString);
            SqlCommand command;

            sql = "SELECT * FROM grades";
            try
            {
                cnn.Open();
                command = new SqlCommand(sql, cnn);
                SqlDataReader sqlReader = command.ExecuteReader();
                dt.Load(sqlReader);
                dv = dt.DefaultView;
                dataGridView2.DataSource = dv;
                sqlReader.Close();
                command.Dispose();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connetionString = "Data Source=RushanthG\\SQLEXPRESS;Initial Catalog=School Management System;User ID=sa;Password=4158;TrustServerCertificate=True";

            string sql = "UPDATE grades SET " +
                         "grade_name = @grade_name, grade_group = @grade_group, grade_order = @grade_order " +
                         "WHERE id = @id";

            using (SqlConnection cnn = new SqlConnection(connetionString))
            using (SqlCommand command = new SqlCommand(sql, cnn))
            {
                command.Parameters.AddWithValue("@grade_name", txtname.Text);
                command.Parameters.AddWithValue("@grade_group", combGroup.Text);
                command.Parameters.AddWithValue("@grade_order", txtOrder.Text);
                command.Parameters.AddWithValue("@id", dataGridView2.CurrentRow.Cells["id"].Value.ToString());

                try
                {
                    cnn.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Successfully Updated!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating grade: " + ex.Message);
                }
            }

            // After updating, refresh the data grid view to reflect changes
            btnRefresh_Click(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = "";

            if (dataGridView2.CurrentRow != null)
            {
                id = dataGridView2.CurrentRow.Cells["id"].Value.ToString();
                DialogResult D = MessageBox.Show("Do You Want to Delete?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (D == DialogResult.Yes)
                {
                    string connetionString = null;
                    connetionString = "Data Source=RushanthG\\SQLEXPRESS;Initial Catalog=School Management System;User ID=sa;Password=4158;TrustServerCertificate=True";
                    SqlConnection cnn;
                    cnn = new SqlConnection(connetionString);
                    SqlCommand command;
                    command = cnn.CreateCommand();
                    string sql = "DELETE FROM grades WHERE id = '" + id + "'";
                    try
                    {
                        cnn.Open();
                        command = new SqlCommand(sql, cnn);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Data Deleted Successfully");
                        cnn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
