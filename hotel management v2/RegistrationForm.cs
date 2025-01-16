using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace hootelv
{
    public partial class RegistrationForm : Form
    {
        private string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kh\OneDrive\Documents\Hotelkv.mdf;Integrated Security=True;Connect Timeout=30";
        public RegistrationForm()
        {
            InitializeComponent();
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void registerloginbtn_Click(object sender, EventArgs e)
        {
            FormLogIn formLogIn = new FormLogIn();
            formLogIn.Show();
            this.Hide();
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(registerUsername.Text) ||
                string.IsNullOrWhiteSpace(registerPassword.Text) ||
                string.IsNullOrWhiteSpace(cregisterPassword.Text))
            {
                MessageBox.Show("Fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (registerPassword.Text.Length < 8)
            {
                MessageBox.Show("Invalid Password! Password must be at least 8 characters.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (registerPassword.Text != cregisterPassword.Text)
            {
                MessageBox.Show("Passwords do not match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connect = new SqlConnection(conn))
            {
                try
                {
                    connect.Open();

                    string checkUsern = "SELECT username FROM users WHERE username = @usern";
                    using (SqlCommand checkU = new SqlCommand(checkUsern, connect))
                    {
                        checkU.Parameters.AddWithValue("@usern", registerUsername.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(checkU);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            string tempUsername = char.ToUpper(registerUsername.Text[0]) + registerUsername.Text.Substring(1);
                            MessageBox.Show($"{tempUsername} already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    string query = "INSERT INTO users (username, password, role, status, date_register) " +
                                   "VALUES (@usern, @pass, @role, @status, @regDate)";
                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@usern", registerUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", registerPassword.Text.Trim());
                        cmd.Parameters.AddWithValue("@role", "Staff");
                        cmd.Parameters.AddWithValue("@status", "Active");
                        cmd.Parameters.AddWithValue("@regDate", DateTime.Today);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Registered successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        FormLogIn LogIn = new FormLogIn();
                        LogIn.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
