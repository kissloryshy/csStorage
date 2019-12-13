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
    public partial class ProviderManager : Form
    {
        bool add;

        public ProviderManager()
        {
            add = false;
            InitializeComponent();
            SQLTasks.getProviders(gridProvider);
            this.Height = 500;
        }

        private void ProviderManager_Load(object sender, EventArgs e)
        {
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //открытие окна
            if (!add)
            {
                add = true;
                this.Height = 650;
                return;
            }

            //добавление и закрытые окна
            if (add)
            {
                long test;
                bool allNumeric = long.TryParse(tbPhoneNumber.Text, out test);

                if (!allNumeric)
                {
                    MessageBox.Show("Ошибка. Некорректный номер телефона");
                }
                else
                {
                    //TODO
                    //if (tbName.Text == "" || tbPhoneNumber.Text == "" || tbCompany.Text == "" || tbAddress.Text == "")
                    {

                        string name = tbName.Text;
                        string phoneNumber = tbPhoneNumber.Text;
                        string company = tbCompany.Text;
                        string address = tbAddress.Text;

                        SQLTasks.addProvider(name, phoneNumber, company, address);

                        //обновление грида
                        //gridProvider.DataSource = SQLTasks.getProviders();
                        SQLTasks.getProviders(gridProvider);
                        
                        add = false;
                        this.Height = 500;
                        return;
                    }
                    //else
                    //{
                    //    MessageBox.Show("Ошибка. Заполните все поля");
                    //}
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string selected_name = gridProvider.CurrentRow.Cells["Name"].Value.ToString();
            string selected_phoneNumber = gridProvider.CurrentRow.Cells["PhoneNumber"].Value.ToString();
            string selected_company = gridProvider.CurrentRow.Cells["Company"].Value.ToString();
            string selected_address = gridProvider.CurrentRow.Cells["Address"].Value.ToString();

            SQLTasks.deleteProvider(selected_name, selected_phoneNumber, selected_company, selected_address);
            SQLTasks.getProviders(gridProvider);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SQLTasks.updateProviders(gridProvider);
        }
    }
}
