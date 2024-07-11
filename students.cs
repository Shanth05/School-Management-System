using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class students : Form
    {
        private readonly string connectionString = "Data Source=RushanthG\\SQLEXPRESS;Initial Catalog=School Management System;User ID=sa;Password=4158;TrustServerCertificate=True";

        public students()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            // Validate each text box individually
            if (string.IsNullOrWhiteSpace(txtad.Text))
            {
                MessageBox.Show("Admission Number cannot be empty for a new record.", "Missing Admission Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtfirst.Text))
            {
                MessageBox.Show("First Name cannot be empty.", "Missing First Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtlast.Text))
            {
                MessageBox.Show("Last Name cannot be empty.", "Missing Last Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtfull.Text))
            {
                MessageBox.Show("Full Name cannot be empty.", "Missing Full Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!rdmale.Checked && !rdfemale.Checked)
            {
                MessageBox.Show("Please select a Gender.", "Missing Gender", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNIC.Text))
            {
                MessageBox.Show("NIC Number cannot be empty.", "Missing NIC Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTp.Text))
            {
                MessageBox.Show("Telephone Number cannot be empty.", "Missing Telephone Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(combGID.Text))
            {
                MessageBox.Show("Please select a Grade.", "Missing Grade", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(combmedium.Text))
            {
                MessageBox.Show("Please select a Medium.", "Missing Medium", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtRadd.Text))
            {
                MessageBox.Show("Resident Address cannot be empty.", "Missing Resident Address", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Proceed with insertion if all fields are valid
            string gender = rdmale.Checked ? "Male" : "Female";

            string sql = "INSERT INTO [students] (admission_no, first_name, last_name, full_name, gender, date_of_birth, student_nic_no, tp_no, grade_id, medium, date_of_admission, resident_address) " +
                         "VALUES (@admission_no, @first_name, @last_name, @full_name, @gender, @date_of_birth, @student_nic_no, @tp_no, @grade_id, @medium, @date_of_admission, @resident_address)";

            using (SqlConnection cnn = new SqlConnection(connectionString))
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
                    RefreshDataGridView(); 
                    ClearFields(); 
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627) // Unique key violation error number
                    {
                        MessageBox.Show("Admission Number already exists. Please use a different Admission Number.", "Duplicate Admission Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Database error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
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
                        RefreshDataGridView(); // Refresh DataGridView after update
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Cannot open connection! " + ex.Message);
                    }
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
                                RefreshDataGridView(); 
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
            RefreshDataGridView(); 
        }

        private void RefreshDataGridView()
        {
            string sql = "SELECT * FROM students";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter da = new SqlDataAdapter(sql, connection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                   
                    dataGridView1.DataSource = dt;

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                // Check if any text boxes already contain data
                if (!string.IsNullOrWhiteSpace(txtad.Text) ||
                    !string.IsNullOrWhiteSpace(txtfirst.Text) ||
                    !string.IsNullOrWhiteSpace(txtlast.Text) ||
                    !string.IsNullOrWhiteSpace(txtfull.Text) ||
                    !string.IsNullOrWhiteSpace(txtNIC.Text) ||
                    !string.IsNullOrWhiteSpace(txtTp.Text) ||
                    !string.IsNullOrWhiteSpace(combGID.Text) ||
                    !string.IsNullOrWhiteSpace(combmedium.Text) ||
                    !string.IsNullOrWhiteSpace(txtRadd.Text))
        

                // Populate text boxes with selected row data
                txtad.Text = row.Cells["admission_no"].Value.ToString();
                txtfirst.Text = row.Cells["first_name"].Value.ToString();
                txtlast.Text = row.Cells["last_name"].Value.ToString();
                txtfull.Text = row.Cells["full_name"].Value.ToString();
                string gender = row.Cells["gender"].Value.ToString();
                rdmale.Checked = gender == "Male";
                rdfemale.Checked = gender == "Female";
                dateTimePicker1.Value = DateTime.Parse(row.Cells["date_of_birth"].Value.ToString());
                txtNIC.Text = row.Cells["student_nic_no"].Value.ToString();
                txtTp.Text = row.Cells["tp_no"].Value.ToString();
                combGID.Text = row.Cells["grade_id"].Value.ToString();
                combmedium.Text = row.Cells["medium"].Value.ToString();
                dateTimePicker2.Value = DateTime.Parse(row.Cells["date_of_admission"].Value.ToString());
                txtRadd.Text = row.Cells["resident_address"].Value.ToString();
            }
        }


        private bool IsFormValid()
        {
            if (string.IsNullOrWhiteSpace(txtad.Text))
            {
                MessageBox.Show("Please fill the Admission Number field.", "Validation Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtad.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtfirst.Text))
            {
                MessageBox.Show("Please fill the First Name field.", "Validation Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtfirst.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtlast.Text))
            {
                MessageBox.Show("Please fill the Last Name field.", "Validation Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtlast.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtfull.Text))
            {
                MessageBox.Show("Please fill the Full Name field.", "Validation Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtfull.Focus();
                return false;
            }

            if (!rdmale.Checked && !rdfemale.Checked)
            {
                MessageBox.Show("Please select a Gender.", "Validation Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rdmale.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNIC.Text))
            {
                MessageBox.Show("Please fill the NIC Number field.", "Validation Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNIC.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTp.Text))
            {
                MessageBox.Show("Please fill the Telephone Number field.", "Validation Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTp.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(combGID.Text))
            {
                MessageBox.Show("Please select a Grade.", "Validation Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                combGID.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(combmedium.Text))
            {
                MessageBox.Show("Please select a Medium.", "Validation Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                combmedium.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtRadd.Text))
            {
                MessageBox.Show("Please fill the Resident Address field.", "Validation Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRadd.Focus();
                return false;
            }

            return true;
        }


        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void ClearFields()
        {
            txtad.Text = "";
            txtfirst.Text = "";
            txtlast.Text = "";
            txtfull.Text = "";
            txtNIC.Text = "";
            txtTp.Text = "";
            txtRadd.Text = "";
            combGID.SelectedIndex = -1; 
            combmedium.SelectedIndex = -1;
           // dateTimePicker1.Value = dateTimePicker1.MinDate;
           // dateTimePicker2.Value = dateTimePicker2.MinDate;
            rdmale.Checked = false;
            rdfemale.Checked = false;

        }

        
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat="dd/MM/yyyy";
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                dateTimePicker1.CustomFormat = "";
            }
        }

        private void dateTimePicker2_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Back)
            {
                dateTimePicker1.CustomFormat = "";
            }
        }

        private void txtTp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Error, A phone number cannot contains letters");
            }
        }

        private void txtTp_TextChanged(object sender, EventArgs e)
        {
            if(txtTp.TextLength == 10)
            {
                txtTp.ForeColor = Color.Black;
            }
            else
            {
                txtTp.ForeColor = Color.Red;
            }
        }
    }
}

