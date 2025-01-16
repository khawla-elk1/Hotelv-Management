using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hootelv
{
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Placeholder for event
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Placeholder for event
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Placeholder for event
        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void admin_addUser1_Load(object sender, EventArgs e)
        {
            // Placeholder for event
        }

        // Generic function to refresh data for a specific control
        private void RefreshControlData(UserControl control)
        {
            if (control is admin_dashboard adDashboard)
            {
                adDashboard.refreshData();
            }
            else if (control is admin_addUser adAddUser)
            {
                adAddUser.refreshData(); // Hypothetical refreshData for admin_addUser
            }
            else if (control is admin_customers adCustomers)
            {
                adCustomers.refreshData(); // Hypothetical refreshData for admin_customers
            }
            else if (control is admin_rooms adRooms)
            {
                adRooms.refreshData(); // Hypothetical refreshData for admin_rooms
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // Show Add User tab
            admin_dashboard1.Visible = false;
            admin_addUser1.Visible = true;
            admin_customers1.Visible = false;
            admin_rooms1.Visible = false;

            RefreshControlData(admin_addUser1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Show Rooms tab
            admin_dashboard1.Visible = false;
            admin_addUser1.Visible = false;
            admin_customers1.Visible = false;
            admin_rooms1.Visible = true;

            RefreshControlData(admin_rooms1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Show Customers tab
            admin_dashboard1.Visible = false;
            admin_addUser1.Visible = false;
            admin_customers1.Visible = true;
            admin_rooms1.Visible = false;

            RefreshControlData(admin_customers1);
        }

        private void admin_rooms1_Load(object sender, EventArgs e)
        {
            // Placeholder for event
        }

        private void DASHBOARD_Click_1(object sender, EventArgs e)
        {
            // Show Dashboard tab
            admin_dashboard1.Visible = true;
            admin_addUser1.Visible = false;
            admin_customers1.Visible = false;
            admin_rooms1.Visible = false;

            RefreshControlData(admin_dashboard1);
        }
    }
}
