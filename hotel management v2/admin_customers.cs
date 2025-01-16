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
    public partial class admin_customers : UserControl
    {
        public admin_customers()
        {
            InitializeComponent();
            displayCustomers();
        
            }
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayCustomers();

        }

        public void displayCustomers()
        {
            // Create an instance of the customersData class
            customersData cData = new customersData();

            // Fetch the customer list using the customerListData method
            List<customersData> listData = cData.customerListData();

            // Bind the fetched list to the DataGridView
            dataGridView1.DataSource = listData;
        }

    }

}
