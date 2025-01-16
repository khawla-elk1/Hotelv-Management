using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hootelv
{
    public partial class ClientInfo : Form
    {
        private string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kh\OneDrive\Documents\Hotelkv.mdf;Integrated Security=True;Connect Timeout=30";
        
        public ClientInfo()
        {
            InitializeComponent();
            displayBookID();
        }

        private void fullNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void xinfoclient_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public void displayBookID()
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                try
                {
                    connect.Open();

                    // Define the SQL query to count the records in the customer table
                    string selectBID = "SELECT COUNT(id) FROM customer";

                    using (SqlCommand cmd = new SqlCommand(selectBID, connect))
                    {
                        // Execute the query and retrieve the count
                        int getBookID = Convert.ToInt32(cmd.ExecuteScalar());

                        // Display the calculated Book ID (e.g., you can display it in a textbox or label)
                        bookid.Text = (getBookID ).ToString(); // Increment for the next booking ID
                    }
                }
                catch (Exception ex)
                {
                    // Handle any errors during database connection or query execution
                    MessageBox.Show($"An error occurred while retrieving the Book ID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void doneButtonc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("sure about you're booking ?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                // Validate all required fields
                if (string.IsNullOrWhiteSpace(fullNameTextBoxc.Text) ||
                    genderComboBoxc.SelectedIndex == -1 ||
                    string.IsNullOrWhiteSpace(addressTextBoxc.Text) ||
                    string.IsNullOrWhiteSpace(emailTextBoxc.Text) ||
                    string.IsNullOrWhiteSpace(contactNumberTextBoxc.Text) ||
                    string.IsNullOrWhiteSpace(hotelData.roomID))
                {
                    MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    using (SqlConnection connect = new SqlConnection(conn))
                    {
                        try
                        {
                            connect.Open();

                            // Define the desired insert query
                            string insertData = @"
                INSERT INTO customer (
                    book_id,
                    full_name,
                    email,
                    contact,
                    gender,
                    address,
                    room_id,
                    price,
                    status_payment,
                    status,
                    date_from,
                    date_to,
                    date_book
                ) VALUES (
                    @bookID,
                    @fullName,
                    @email,
                    @contact,
                    @gender,
                    @address,
                    @roomID,
                    @price,
                    @statusPayment,
                    @status,
                    @dateFrom,
                    @dateTo,
                    @dateBook
                )";

                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                // Add parameters to the query
                                cmd.Parameters.AddWithValue("@bookID", Guid.NewGuid().ToString()); // Generate a unique book ID
                                cmd.Parameters.AddWithValue("@fullName", fullNameTextBoxc.Text.Trim());
                                cmd.Parameters.AddWithValue("@email", emailTextBoxc.Text.Trim());
                                cmd.Parameters.AddWithValue("@contact", contactNumberTextBoxc.Text.Trim());
                                cmd.Parameters.AddWithValue("@gender", genderComboBoxc.SelectedItem.ToString());
                                cmd.Parameters.AddWithValue("@address", addressTextBoxc.Text.Trim());
                                cmd.Parameters.AddWithValue("@roomID", hotelData.roomID);
                                cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(hotelData.price));
                                cmd.Parameters.AddWithValue("@statusPayment", "Paid"); // Example status
                                cmd.Parameters.AddWithValue("@status", "Checked In"); // Example status
                                cmd.Parameters.AddWithValue("@dateFrom", hotelData.fromDate); // Example: tomorrow's date
                                cmd.Parameters.AddWithValue("@dateTo", hotelData.toDate); // Example: one week from now
                                cmd.Parameters.AddWithValue("@dateBook", DateTime.Now);

                                // Execute the query
                                cmd.ExecuteNonQuery();

                                // Notify the user of success
                                MessageBox.Show("Booked successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                updateRoomStatus();
                                // Clear fields after adding the data
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An error occurred: {ex.Message}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Hide();
                        }
                    }
                }
            }   
        }
        public void updateRoomStatus()
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();

                string updateStatus = "UPDATE rooms SET status = @status WHERE room_id = @roomID";

                using (SqlCommand cmd = new SqlCommand(updateStatus, connect))
                {
                    // Ajouter les paramètres pour la requête SQL
                    cmd.Parameters.AddWithValue("@status", "Unavailable");
                    cmd.Parameters.AddWithValue("@roomID", hotelData.roomID);

                    // Exécuter la requête
                    cmd.ExecuteNonQuery();
                }
            }
        }


        // Function to clear input fields after successful submission
        private void clearFields()
        {
            fullNameTextBoxc.Text = "";
            genderComboBoxc.SelectedIndex = -1;
            addressTextBoxc.Text = "";
            emailTextBoxc.Text = "";
            contactNumberTextBoxc.Text = "";
            hotelData.roomID = "";
        }

        private void clearButtonc_Click(object sender, EventArgs e)
        {
            // Efface le contenu des TextBox
            fullNameTextBoxc.Text = "";
            emailTextBoxc.Text = "";
            contactNumberTextBoxc.Text = "";

            // Réinitialise les ComboBox à leur état initial
            genderComboBoxc.SelectedIndex = -1; // Aucun élément sélectionné
            addressTextBoxc.Text = "";
        }
    }
}
