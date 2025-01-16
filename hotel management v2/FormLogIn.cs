using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace hootelv
{
    public partial class FormLogIn : Form
    {
        private string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kh\OneDrive\Documents\Hotelkv.mdf;Integrated Security=True;Connect Timeout=30";

        public FormLogIn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxMinimize_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxMinimize, "Minimize");
  
        }

        private void pictureBoxClose_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxClose, "Close");

        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
        this.Close();
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(textBoxUsername.Text=="" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }else
            {
                using (SqlConnection connect = new SqlConnection(conn))
                {
                    connect.Open();
                    string selectData = "select * from users where (username = @usern  and password = @pass) and status = @status";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                    cmd.Parameters.AddWithValue("@usern",textBoxUsername.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", textBoxPassword.Text.Trim());
                    cmd.Parameters.AddWithValue("@status","Active");
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        if (table.Rows.Count != 0)
                        {
                            MessageBox.Show("Login successfully :)", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            string selectRole = "SELECT role FROM users WHERE username = @usern AND password = @pass";
                            using (SqlCommand getRole = new SqlCommand(selectRole, connect))
                            {
                                // Add parameters to avoid SQL injection
                                getRole.Parameters.AddWithValue("@usern", textBoxUsername.Text.Trim());
                                getRole.Parameters.AddWithValue("@pass", textBoxPassword.Text.Trim());

                                // Execute the query and retrieve the role
                                string userRole = getRole.ExecuteScalar() as string;

                                if (userRole == "Admin")
                                {
                                    // Open the Admin form
                                    AdminMainForm adminForm = new AdminMainForm();
                                    adminForm.Show();
                                    this.Hide(); // Hide the current login form
                                }
                                else if (userRole == "Staff")
                                {
                                    // Open the Staff form
                                    staffMainForm staffForm = new staffMainForm();
                                    staffForm.Show();
                                    this.Hide(); // Hide the current login form
                                }
                                else
                                {
                                    MessageBox.Show("Unknown role or invalid credentials. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }else
                        {
                            MessageBox.Show("Incorrect username or password :/", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }

            }
        }

        private void loginregisterbtn_Click(object sender, EventArgs e)
        {
            RegistrationForm Regform = new RegistrationForm();
            Regform.Show();
            this.Hide();
        }
    }
}
