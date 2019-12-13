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
    public partial class Discount : Form
    {
        bool add;

        public Discount()
        {
            InitializeComponent();
            add = false;
            this.Height = 256;
        }

        private void Discount_Load(object sender, EventArgs e)
        {
            SQLTasks.getDiscount(gridDiscount);
        }

        private void btnAddDiscount_Click(object sender, EventArgs e)
        {
            if (!add)
            {
                this.Height = 335;
                add = true;

                return;
            }

            if (add)
            {
                this.Height = 256;

                if (tbSize.Text == "")
                {
                    MessageBox.Show("Заполните все поля");
                }
                else if (tbSize.Text == "0")
                {
                    MessageBox.Show("Скидка должна быть больше 0");
                }
                else if (dtpEndTime.Value.Date < DateTime.Now.Date)
                {
                    MessageBox.Show("Выбранная дата должна быть больше текущей");
                }
                else
                {
                    string size = tbSize.Text;
                    string endDate = dtpEndTime.Text;

                    SQLTasks.addDiscount(size, endDate);
                    SQLTasks.getDiscount(gridDiscount);
                    MessageBox.Show("Скидка добавлена успешно");
                }

                add = false;
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string selected_id = gridDiscount.CurrentRow.Cells["Key"].Value.ToString();

            SQLTasks.deleteDiscount(selected_id);
            SQLTasks.getDiscount(gridDiscount);
        }
    }
}
