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
    public partial class staff_bookRoom : UserControl
    {
        private int getID = 0;
        private decimal regprice = 0;
        private string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kh\OneDrive\Documents\Hotelkv.mdf;Integrated Security=True;Connect Timeout=30";

        public staff_bookRoom()
        {
            InitializeComponent();
            displayRooms();
        }

        public void displayRooms()
        {
            // Create an instance of roomsData to fetch data
            roomsData rData = new roomsData();

            // Fetch the list of room data
            List<roomsData> listD = rData.roomsDataList();

            // Bind the data to the DataGridView
            dataGridView1.DataSource = listD;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getID = (int)row.Cells[0].Value;
                bookRoom_roomID.Text = row.Cells[1].Value.ToString();
                bookRoom_roomType.Text = row.Cells[2].Value.ToString();
                bookRoom_roomName.Text = row.Cells[3].Value.ToString();

                // Assign the room price to the class-level variable
                regprice = Convert.ToDecimal(row.Cells[4].Value);

                // Display the price in the respective textbox
                bookRoom_regPrice.Text = regprice.ToString("0.00");
                bookRoom_imageView.ImageLocation = row.Cells[5].Value.ToString();

                bookRoom_status.Text = row.Cells[6].Value.ToString();
            }
        }

        private void bookRoom_schedulebtn_Click(object sender, EventArgs e)
        {
            DateTime fromDate = bookRoom_from.Value.Date;
            DateTime toDate = bookRoom_roomto.Value.Date;

            TimeSpan countDays = toDate - fromDate;
            int days = countDays.Days;

            if (days < 0)
            {
                MessageBox.Show("End date cannot be earlier than start date.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bookRoom_total.Text = "0.00";
            }
            else if (days == 0)
            {
                // If the room is booked for the same day, only the registration price is shown
                bookRoom_total.Text = regprice.ToString("0.00");
            }
            else
            {
                // Calculate the total price based on the number of days
                decimal totalPrice = regprice * days;
                bookRoom_total.Text = totalPrice.ToString("0.00");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Placeholder for label click event if needed
        }

        private void bookRoom_bookbtn_Click(object sender, EventArgs e)
        {
            Form formbg = new Form(); // Crée une nouvelle instance de formulaire pour le fond
            try
            {
                using (ClientInfo ciForm = new ClientInfo())
                {
                    formbg.StartPosition = FormStartPosition.Manual;
                    formbg.FormBorderStyle = FormBorderStyle.None; // Supprime les bordures du formulaire
                    formbg.Opacity = .80d; // Définit l'opacité
                    formbg.BackColor = Color.Black; // Définit le fond noir
                    formbg.WindowState = FormWindowState.Maximized;
                    formbg.TopMost = true; // Place le formulaire au premier plan
                    formbg.Location = this.Location; // Positionne le formulaire à la même position que l'actuel
                    formbg.ShowInTaskbar = false; // Masque le formulaire dans la barre des tâches
                    formbg.Show(); // Affiche le formulaire en arrière-plan

                    ciForm.Owner = formbg; // Définit le formulaire actuel comme parent
                    ciForm.ShowDialog(); // Affiche le formulaire client comme une boîte de dialogue
                   
                    formbg.Dispose(); // Libère les ressources après la fermeture de la boîte de dialogue

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                formbg.Dispose(); // Libère les ressources après la fermeture de la boîte de dialogue
            }
        }

    }
}
