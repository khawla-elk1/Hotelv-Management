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
using System.IO;


namespace hootelv
{
    public partial class admin_rooms : UserControl
    {
        private string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kh\OneDrive\Documents\Hotelkv.mdf;Integrated Security=True;Connect Timeout=30";

        public admin_rooms()
        {
            InitializeComponent();
            displayRoomsData();
        }
        public void displayRoomsData()
        {
            // Create an instance of roomsData to fetch data
            roomsData rData = new roomsData();

            // Fetch the list of room data
            List<roomsData> listD = rData.roomsDataList();

            // Bind the data to the DataGridView
            dataGridView1.DataSource = listD;
        }

        public bool isEmpty()
        {
            if (string.IsNullOrEmpty(rooms_roomID.Text) ||
                string.IsNullOrEmpty(rooms_roomname.Text) ||
                rooms_roomtype.SelectedIndex == -1 ||
                string.IsNullOrEmpty(rooms_price.Text) ||
                rooms_status.SelectedIndex == -1 ||
                rooms_picture.Image == null)
            {
                return true; // Retourne vrai si un champ est vide ou invalide
            }
            else
            {
                return false; // Retourne faux si tous les champs sont valides
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void rooms_picture_Click(object sender, EventArgs e)
        {

        }

        private void rooms_addbtn_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                MessageBox.Show("Please fill all required fields!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try {
                    using (SqlConnection connect = new SqlConnection(conn))
                    {

                        connect.Open();

                        // Vérification si le room_id existe déjà
                        string checkRoomID = "SELECT room_id FROM rooms WHERE room_id = @roomID";
                        using (SqlCommand checkRID = new SqlCommand(checkRoomID, connect))
                        {
                            checkRID.Parameters.AddWithValue("@roomID", rooms_roomID.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(checkRID);
                            DataTable table = new DataTable();

                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show(rooms_roomID.Text.Trim() + " already exists!",
                                                "Error Message",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Error);
                            }
                            else
                            {
                                // Requête d'insertion
                                string insertData = "INSERT INTO rooms (room_id, type, room_name, price, image_path, status, date_register) " +
                                                    "VALUES (@roomID, @type, @name, @price, @path, @status, @date_reg)";
                                string path = Path.Combine(@"C:\Users\kh\source\repos\hootelv\hootelv\roomsKHv\" + rooms_roomID.Text.Trim() + ".jpg");
                                string directoryPath = Path.GetDirectoryName(path);
                                if (!Directory.Exists(directoryPath))
                                {

                                    Directory.CreateDirectory(directoryPath);
                                }

                                File.Copy(rooms_picture.ImageLocation, path, true);
                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    // Ajout des paramètres à la commande
                                    cmd.Parameters.AddWithValue("@roomID", rooms_roomID.Text.Trim());
                                    cmd.Parameters.AddWithValue("@type", rooms_roomtype.SelectedItem.ToString());
                                    cmd.Parameters.AddWithValue("@name", rooms_roomname.Text.Trim());
                                    cmd.Parameters.AddWithValue("@price", rooms_price.Text.Trim());
                                    cmd.Parameters.AddWithValue("@path", path);
                                    cmd.Parameters.AddWithValue("@status", rooms_status.SelectedItem.ToString());

                                    DateTime today = DateTime.Today;
                                    cmd.Parameters.AddWithValue("@date_reg", today);

                                    // Exécution de la commande
                                    cmd.ExecuteNonQuery();

                                    // Message de succès
                                    MessageBox.Show("Room added successfully!",
                                                    "Success",
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Information);




                                }
                            }
                        }

                    }
                }
                catch(Exception ex) {
                    MessageBox.Show("error " + ex,
                                                   "error",
                                                   MessageBoxButtons.OK,
                                                   MessageBoxIcon.Error);


                }

            }
            
        }
        private void rooms_importbtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Initialisation de l'OpenFileDialog
                OpenFileDialog file = new OpenFileDialog();
                string imagePath = ""; // Variable pour stocker le chemin de l'image

                // Configuration des types de fichiers acceptés
                file.Filter = "Image Files (*.jpg; *.png)|*.jpg;*.png";

                // Afficher la boîte de dialogue pour sélectionner un fichier
                if (file.ShowDialog() == DialogResult.OK)
                {
                    // Récupérer le chemin complet de l'image sélectionnée
                    imagePath = file.FileName;

                    // Charger l'image dans le contrôle PictureBox
                    rooms_picture.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                // Affichage d'un message d'erreur en cas d'exception
                MessageBox.Show($"Error: {ex}",
                                "Error Message",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
        private void rooms_deletebtn_Click(object sender, EventArgs e)
        {
            // Validation to check if a room is selected
            if (string.IsNullOrWhiteSpace(rooms_roomID.Text) ||
                string.IsNullOrWhiteSpace(rooms_roomname.Text) ||
                rooms_roomtype.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(rooms_price.Text) ||
                rooms_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a room first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirmation message
            if (MessageBox.Show($"Are you sure you want to delete Room ID: {rooms_roomID.Text.Trim()}?",
                "Confirmation Message",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (SqlConnection connect = new SqlConnection(conn))
                {
                    try
                    {
                        connect.Open();

                        // Delete query
                        string deleteData = "DELETE FROM rooms WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                        {
                            // Adding parameters to avoid SQL injection
                            cmd.Parameters.AddWithValue("@id", id); // Ensure `id` is set from the selected DataGridView row

                            // Execute the delete command
                            cmd.ExecuteNonQuery();

                            // Refresh data and notify the user
                            displayRoomsData();
                            clearFields();
                            MessageBox.Show("Room deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while deleting the room: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void rooms_updatebtn_Click(object sender, EventArgs e)
        {
            // Validation of fields
            if (string.IsNullOrWhiteSpace(rooms_roomID.Text) ||
                string.IsNullOrWhiteSpace(rooms_roomname.Text) ||
                rooms_roomtype.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(rooms_price.Text) ||
                rooms_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select a Room first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirmation message
            if (MessageBox.Show($"Are you sure you want to update Room ID: {rooms_roomID.Text.Trim()}?",
                "Confirmation Message",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (SqlConnection connect = new SqlConnection(conn))
                {
                    try
                    {
                        connect.Open();

                        // Update query
                        string updateData = @"
                    UPDATE rooms
                    SET 
                        room_id = @roomID, 
                        type = @type, 
                        room_name = @name, 
                        price = @price, 
                        status = @status, 
                        date_update = @update
                    WHERE 
                        id = @id";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            // Adding parameters to avoid SQL injection
                            cmd.Parameters.AddWithValue("@roomID", rooms_roomID.Text.Trim());
                            cmd.Parameters.AddWithValue("@type", rooms_roomtype.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@name", rooms_roomname.Text.Trim());
                            cmd.Parameters.AddWithValue("@price", rooms_price.Text.Trim());
                            cmd.Parameters.AddWithValue("@status", rooms_status.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@update", DateTime.Now);
                            cmd.Parameters.AddWithValue("@id", id); // Ensure `id` is set from the selected DataGridView row

                            // Execute the update command
                            cmd.ExecuteNonQuery();

                            // Refresh data and notify the user
                            displayRoomsData();
                            MessageBox.Show("Room updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while updating the room: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {}  
       
        private int id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];


                // Populate the form fields
                id = (int)row.Cells[0].Value;
                rooms_roomID.Text = row.Cells[1].Value.ToString();
                rooms_roomtype.SelectedItem = row.Cells[2].Value.ToString();
                rooms_roomname.Text = row.Cells[3].Value.ToString();
                rooms_price.Text = row.Cells[4].Value.ToString();
                rooms_picture.ImageLocation = row.Cells[5].Value.ToString();

                rooms_status.Text = row.Cells[6].Value.ToString();

            }
        }

        public void clearFields()
        {
            // Reset all input fields
            rooms_roomID.Text = "";                // Clear the Room ID TextBox
            rooms_roomtype.SelectedIndex = -1;         // Reset the Type ComboBox
            rooms_roomname.Text = "";              // Clear the Room Name TextBox
            rooms_price.Text = "";                 // Clear the Price TextBox
            rooms_picture.Image = null;            // Clear the PictureBox
            rooms_status.SelectedIndex = -1;  
            // Reset the Status ComboBox
        }

        private void rooms_Clearbtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}
