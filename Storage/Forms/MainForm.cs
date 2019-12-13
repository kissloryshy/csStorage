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
    public partial class MainForm : Form
    {
        Form login;
        string idEmployee;
        string name;
        string position;
        string[] permissions;
        bool add;
        private static DataTable products;

        public MainForm(string name, string positoin, string[] permissions, Form form, string idEmployee)
        {
            //1023; 679
            add = false;
            this.idEmployee = idEmployee;
            this.name = name;
            this.position = positoin;
            this.permissions = permissions;
            login = form;

            InitializeComponent();

            showWithPermissions();
            changeSize();
            initGridBuy();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lbName.Text = name;
            lbPosition.Text = position;

            SQLTasks.getProducts(gridProducts);

            //удаление старых скидок
            SQLTasks.deleteOldDiscount();
        }

        private void showWithPermissions()
        {
            string per = "";
            for (int i = 0; i < permissions.Length; i++)
            {
                per += permissions[i];
            }

            if (!per.Contains("ДобавлениеПоставщика"))
                btnAddProvider.Visible = false;

            if (!per.Contains("ИзменениеКаталога"))
                btnUpdateCatalog.Visible = false;

            if (!per.Contains("СозданиеКвитанции"))
                btnCreateCheck.Visible = false;

            if (!per.Contains("ДобавлениеТовара"))
                btnAddProducts.Visible = false;

            if (!per.Contains("НазначениеСкидок"))
                btnDiscount.Visible = false;

            if (!per.Contains("ПродажаТоваров"))
                btnBuy.Visible = false;

            if (!per.Contains("Отчетность"))
                btnReport.Visible = false;

            if (!per.Contains("ПриемУвольнениеСотрудников"))
                btnPersonal.Visible = false;

            if (!per.Contains("ИзменениеПрав"))
                btnPermissionChenging.Visible = false;
        }

        private void changeSize()
        {
            position = position.ToLower();

            if (position == "покупатель")
                this.Height = Height - 200;

            if (position == "продавец")
                this.Height = Height - 170;

            if (position == "директор")
                this.Height = Height - 50;
        }

        private void initGridBuy()
        {
            products = new DataTable();
            DataColumn c0 = new DataColumn("Key");
            DataColumn c1 = new DataColumn("Name");
            DataColumn c2 = new DataColumn("Amount");
            DataColumn c3 = new DataColumn("Price");
            DataColumn c4 = new DataColumn("Provider");
            DataColumn c5 = new DataColumn("KeyDiscount");
            DataColumn c6 = new DataColumn("PriceWithDiscount");
            products.Columns.Add(c0);
            products.Columns.Add(c1);
            products.Columns.Add(c2);
            products.Columns.Add(c3);
            products.Columns.Add(c4);
            products.Columns.Add(c5);
            products.Columns.Add(c6);
            gridBuys.DataSource = products;
        }

        private void gridProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string key = gridProducts.CurrentRow.Cells["Key"].Value.ToString();

            for (int i = 0; i < products.Rows.Count; i++)
            {
                if (gridBuys.Rows[i].Cells["Key"].Value.ToString() == key)
                    return;
            }

            DataRow row;
            row = products.NewRow();
            row["Key"] = gridProducts.CurrentRow.Cells["Key"].Value.ToString();
            row["Name"] = gridProducts.CurrentRow.Cells["Name"].Value.ToString();
            row["Amount"] = 1;
            row["Price"] = gridProducts.CurrentRow.Cells["Price"].Value.ToString();
            row["Provider"] = gridProducts.CurrentRow.Cells["Provider"].Value.ToString();
            row["KeyDiscount"] = gridProducts.CurrentRow.Cells["KeyDiscount"].Value.ToString();
            row["PriceWithDiscount"] = gridProducts.CurrentRow.Cells["PriceWithDiscount"].Value.ToString();
            products.Rows.Add(row);
        }

        private void btnAccountSetting_Click(object sender, EventArgs e)
        {
            AccountMenager menager = new AccountMenager();
            menager.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Close();
        }

        private void btnAddProvider_Click(object sender, EventArgs e)
        {
            ProviderManager providersManager = new ProviderManager();
            providersManager.Show();
        }

        private void btnChangeCatalog_Click(object sender, EventArgs e)
        {
            SQLTasks.updateProducts(gridProducts);
        }

        private void btnUpdateCatalog_Click(object sender, EventArgs e)
        {
            SQLTasks.updateProducts(gridProducts);
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            staff.Show();
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            Discount discount = new Discount();
            discount.Show();
        }

        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            if (!add)
            {
                this.Height += 300;
                add = true;

                return;
            }

            //if (add)
            //{
            //    this.Height -= 300;

            //    if (tbName.Text == "" ||
            //        cbPosition.Text == "" ||
            //        tbAccrued.Text == "" ||
            //        tbEmail.Text == "" ||
            //        tbPhoneNumber.Text == "" ||
            //        tbAddress.Text == "")
            //    {
            //        MessageBox.Show("Заполните все поля");
            //    }
            //    else
            //    {
            //        string name = tbName.Text;
            //        string positoin = cbPosition.Text;
            //        string accrued = tbAccrued.Text;
            //        string email = tbEmail.Text;
            //        string phoneNumber = tbPhoneNumber.Text;
            //        string address = tbAddress.Text;

            //        SQLTasks.addStaff(name, positoin, accrued, email, phoneNumber, address);
            //        SQLTasks.getStaff(gridStaff);
            //        MessageBox.Show("Сотрудник добавлен успешно");
            //    }

            //    add = false;
            //    return;
            //}

            //this.Height
            //SQLTasks.addProduct();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (gridBuys.Rows.Count == 0)
            {
                MessageBox.Show("Ошибка, корзина пуста");
                return;
            }

            //check amount
            for (int i = 0; i < gridBuys.Rows.Count; i++)
            {
                string key = gridBuys.Rows[i].Cells["Key"].Value.ToString();
                string amount = gridBuys.Rows[i].Cells["Amount"].Value.ToString();
                int storageAmount = SQLTasks.getProductAmount(key, amount);

                if (storageAmount - Int32.Parse(amount) < 0)
                {
                    MessageBox.Show("Ощибка. Недостаточно товаров");
                    return;
                }
            }

            //updateProductAmount
            for (int i = 0; i < gridBuys.Rows.Count; i++)
            {
                string key = gridBuys.Rows[i].Cells["Key"].Value.ToString();
                string amount = gridBuys.Rows[i].Cells["Amount"].Value.ToString();
                //SQLTasks.updateProductAmount(key, amount);
            }

            SQLTasks.getProducts(gridProducts);

            //clear buys
            for (int i = 0; i < gridBuys.Rows.Count; i++)
            {
                gridBuys.Rows.RemoveAt(i);
            }

            //selected customer
            Customer customer = new Customer();
            customer.ShowDialog();
            string id = customer.idCustomer;

            Console.WriteLine(id);

            if (id == "")
            {
                MessageBox.Show("Покупатель не выбран");

            }
            else
            {
                //create selling
                SQLTasks.addSelling(int.Parse(id), int.Parse(idEmployee));
            }
        }
    }
}
