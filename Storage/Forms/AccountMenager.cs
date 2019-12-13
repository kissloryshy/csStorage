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
    public partial class AccountMenager : Form
    {
        public AccountMenager()
        {
            InitializeComponent();
            TopMost = true;
        }

        private void AccountMenager_Load(object sender, EventArgs e)
        {
            string raw = SQLTasks.getEmployeeInfo();
            string[] info = raw.Split(';');

            tbEmail.Text = info[0];
            tbPhone.Text = info[1];
            tbAddress.Text = info[2];
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            long test;
            bool allNumeric = long.TryParse(tbPhone.Text, out test);

            if (!allNumeric)
            {
                MessageBox.Show("Ошибка. Некорректный номер телефона");
                return;
            }

            if (!tbEmail.Text.Contains('@') || !tbEmail.Text.Contains('.'))
            {
                MessageBox.Show("Ошибка. Неправильно введена почта");
            }

            if (tbEmail.Text == "" || tbPhone.Text == "" || tbAddress.Text == "")
            {
                MessageBox.Show("Ошибка. Не все поля заполнены");
            }
            else
            {
                string info = tbEmail.Text + ";" + tbPhone.Text + ";" + tbAddress.Text;
                bool status = SQLTasks.updateEmployeeInfo(info);
                
                if (status)
                {
                    MessageBox.Show("Данные успешно изменены");
                }
                else
                {
                    MessageBox.Show("Ошибка изменения данных");
                }
            }
        }
    }
}
