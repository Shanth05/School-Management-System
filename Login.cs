using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace School_Management_System
{
    public partial class Login : Form
    {
        SqlConnection connect = new SqlConnection("Data Source=RushanthG\\SQLEXPRESS;Initial Catalog=School Management System;User ID=sa;Password=4158;TrustServerCertificate=True");
        public Login()
        {
            InitializeComponent();
            txtpassword.PasswordChar = '*'; // Set the masking character initially
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "" || txtpassword.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    connect.Open();

                    String selectData = "SELECT * from users Where username = @username AND password = @password";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@username",txtuser.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", txtpassword.Text.Trim());
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count >= 1)
                        {
                            MessageBox.Show("Login Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            main frm = new main();
                            frm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Username/Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error connecting Database " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkshow_CheckedChanged(object sender, EventArgs e)
        {
            txtpassword.PasswordChar = checkshow.Checked ? '\0' : '*';

        }
    }
}
