using hotelManagementSystem;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace hootelv
{
    public partial class admin_addUser : UserControl
    {
        private string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kh\OneDrive\Documents\Hotelkv.mdf;Integrated Security=True;Connect Timeout=30";

        public admin_addUser()
        {
            InitializeComponent();
            displayData();
        }
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayData();
        }

        public void displayData()
        {
           
                // Création d'une instance de usersData pour récupérer les données
                usersData uData = new usersData();

                // Liaison des données récupérées avec le DataGridView
                dataGridView1.DataSource = uData.listUsersData();
            
           
        }


        private void label5_Click(object sender, EventArgs e)
        {
            // Placeholder for label click event (if needed)
        }




        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addUser_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            // Validate that all fields are filled
            if (string.IsNullOrWhiteSpace(addUser_usernamee.Text) ||
                string.IsNullOrWhiteSpace(addUser_password.Text) ||
                addUser_role.SelectedIndex == -1 ||
                addUser_status.SelectedIndex == -1)
            {
                MessageBox.Show("Fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate password length
            if (addUser_password.Text.Length < 8)
            {
                MessageBox.Show("Invalid Password! Password must be at least 8 characters.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(conn))
            {
                try
                {
                    connection.Open();

                    // Check if the username already exists
                    string checkUsern = "SELECT username FROM users WHERE username = @usern";
                    using (SqlCommand checkU = new SqlCommand(checkUsern, connection))
                    {
                        checkU.Parameters.AddWithValue("@usern", addUser_usernamee.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(checkU);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            string tempUsern = char.ToUpper(addUser_usernamee.Text[0]) + addUser_usernamee.Text.Substring(1);
                            MessageBox.Show($"{tempUsern} already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Insert new user
                    string insertData = "INSERT INTO users (username, password, role, status, date_register) " +
                                        "VALUES (@usern, @pass, @role, @status, @date)";
                    using (SqlCommand insertU = new SqlCommand(insertData, connection))
                    {
                        insertU.Parameters.AddWithValue("@usern", addUser_usernamee.Text.Trim());
                        insertU.Parameters.AddWithValue("@pass", addUser_password.Text.Trim());
                        insertU.Parameters.AddWithValue("@role", addUser_role.SelectedItem.ToString());
                        insertU.Parameters.AddWithValue("@status", addUser_status.SelectedItem.ToString());
                        insertU.Parameters.AddWithValue("@date", DateTime.Today);

                        insertU.ExecuteNonQuery();
                        clearFields();
                        MessageBox.Show("User added successfully :)", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void clearFields()
        {
            // Efface le contenu des TextBox
            addUser_usernamee.Text = "";
            addUser_password.Text = "";

            // Réinitialise les ComboBox à leur état initial
            addUser_role.SelectedIndex = -1; // Aucun élément sélectionné
            addUser_status.SelectedIndex = -1;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            // Validation des champs
            if (addUser_usernamee.Text == "" ||
               addUser_password.Text == "" ||
                addUser_role.SelectedIndex == -1 ||
                addUser_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (MessageBox.Show($"Are you sure you want to update ID: {getID}?",
                    "Confirmation Message",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(conn))
                    {

                        connect.Open();

                        string updateData = "UPDATE users SET password = @pass, role = @role, status = @status WHERE username = @usern";
                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@pass", addUser_password.Text.Trim());
                            cmd.Parameters.AddWithValue("@role", addUser_role.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@status", addUser_status.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@usern", addUser_usernamee.Text.Trim());


                            // Exécuter la commande
                            cmd.ExecuteNonQuery();
                            displayData();
                            MessageBox.Show("User updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }


                    }

                }

            }
        }
        // Variable pour stocker l'ID de l'utilisateur sélectionné


        // Méthode pour gérer l'événement CellClick du DataGridView
        private int getID;
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Vérifiez que l'utilisateur clique sur une ligne valide
            if (e.RowIndex != -1) // Vérifie que l'index de la ligne est valide
            {
                // Récupère la ligne cliquée
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Récupérer les valeurs des cellules de la ligne et les remplir dans le formulaire
                getID = (int)row.Cells[0].Value; // Colonne ID
                addUser_usernamee.Text = row.Cells[1].Value.ToString(); // Colonne Username
                addUser_password.Text = row.Cells[2].Value.ToString(); // Colonne Password
                addUser_role.SelectedItem = row.Cells[3].Value.ToString(); // Colonne Role
                addUser_status.SelectedItem = row.Cells[4].Value.ToString(); // Colonne Status
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            // Validation des champs
            if (addUser_usernamee.Text == "" ||
               addUser_password.Text == "" ||
                addUser_role.SelectedIndex == -1 ||
                addUser_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (MessageBox.Show($"Are you sure you want to update ID: {getID}?",
                    "Confirmation Message",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(conn))
                    {

                        connect.Open();

                        string deleteData = "delete from users WHERE username = @usern";
                        using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                        {
                            cmd.Parameters.AddWithValue("@pass", addUser_password.Text.Trim());
                            cmd.Parameters.AddWithValue("@role", addUser_role.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@status", addUser_status.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@usern", addUser_usernamee.Text.Trim());


                            // Exécuter la commande
                            cmd.ExecuteNonQuery();
                            displayData();
                            MessageBox.Show("User deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }


                    }

                }

            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
 
        }
    }
}






