using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Storage
{
    public partial class Staff : Form
    {
        bool add;

        public Staff()
        {
            //868; 340
            add = false;
            InitializeComponent();
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            this.Height = 340;
            SQLTasks.getStaff(gridStaff);
            fillCbPosition();
        }

        private void fillCbPosition()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = SQLTasks.getPositions();
            cbPosition.DataSource = bindingSource;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string selected_id = gridStaff.CurrentRow.Cells["Key"].Value.ToString();

            SQLTasks.deleteAuth(selected_id);
            SQLTasks.deleteStaff(selected_id);
            SQLTasks.getStaff(gridStaff);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SQLTasks.updateStaff(gridStaff);
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            if (!add)
            {
                this.Height = 500;
                add = true;
                
                return;
            }

            if (add)
            {
                this.Height = 340;

                if (tbName.Text == "" ||
                    cbPosition.Text == "" ||
                    tbAccrued.Text == "" ||
                    tbEmail.Text == "" ||
                    tbPhoneNumber.Text == "" ||
                    tbAddress.Text == "")
                {
                    MessageBox.Show("Заполните все поля");
                }
                else
                {
                    string name = tbName.Text;
                    string positoin = cbPosition.Text;
                    string accrued = tbAccrued.Text;
                    string email = tbEmail.Text;
                    string phoneNumber = tbPhoneNumber.Text;
                    string address = tbAddress.Text;

                    SQLTasks.addStaff(name, positoin, accrued, email, phoneNumber, address);
                    SQLTasks.getStaff(gridStaff);
                    MessageBox.Show("Сотрудник добавлен успешно");
                }

                add = false;
                return;
            }
        }
    }
}
