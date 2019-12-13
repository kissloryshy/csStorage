using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Storage.Forms
{
    public partial class Customer : Form
    {
        private bool add;

        public string idCustomer
        {
            set;
            get;
        }

        public Customer()
        {
            //597; 367
            add = false;
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            SQLTasks.getCustomer(gridCustomer);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (gridCustomer.SelectedRows.Count == 1)
            {
                idCustomer = gridCustomer.SelectedRows[0].Cells["Id"].Value.ToString();
                this.Close();
            }
            else
            {
                MessageBox.Show("Покупатель не выбран");
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {

        }
    }
}
