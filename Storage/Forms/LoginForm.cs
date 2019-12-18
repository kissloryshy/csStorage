using Storage.Forms;
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
    public partial class formLogin : Form
    {

        public formLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SQLTasks.SQLConnect();

            tbLogin.ForeColor = Color.Gray;
            tbPassword.ForeColor = Color.Gray;
        }

        //textbox login click
        private void tbLogin_Click(object sender, EventArgs e)
        {
            tbLogin.Text = "";
            tbLogin.ForeColor = Color.Black;
        }

        //textbox password click
        private void tbPassword_Click(object sender, EventArgs e)
        {
            tbPassword.Text = "";
            tbPassword.ForeColor = Color.Black;
            tbPassword.UseSystemPasswordChar = true;
        }

        //textbox login leave focus
        private void tbLogin_Leave(object sender, EventArgs e)
        {
            if (tbLogin.Text == "")
            {
                tbLogin.Text = "Введите логин";
                tbLogin.ForeColor = Color.Gray;
            }
        }

        //textbox password leave focus
        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if (tbPassword.Text == "")
            {
                tbPassword.Text = "Введите пароль";
                tbPassword.ForeColor = Color.Gray;
                tbPassword.UseSystemPasswordChar = false;
            }
        }

        //button login click
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //return idEmployee + ';' + name + ';' + position + ';' + permissions;
            string information = SQLTasks.verify(tbLogin.Text, tbPassword.Text);

            string[] inf = information.Split(';');
            string idEmployee = inf[0];
            string employerName = inf[1];
            string position = inf[2];

            //формирование массива из разрешений
            string[] permitions = new string[inf.Length - 3];

            for (int i = 0; i < permitions.Length; i++)
            {
                permitions[i] = inf[i + 3];
            }

            if (permitions[0] == "-1")
            {
                MessageBox.Show("Access denied");
            }
            else
            {
                this.Hide();
                MainForm2 f2 = new MainForm2(employerName, position, permitions, this, idEmployee);
                f2.Show();
            }
        }
    }
}
