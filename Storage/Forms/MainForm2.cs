using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Storage.Forms
{
    public partial class MainForm2 : Form
    {
        Form login;
        string idEmployee;
        string name;
        string position;
        string[] permissions;
        bool add;
        private static DataTable products;
        private static SqlConnection connection;

        public MainForm2(string name, string positoin, string[] permissions, Form form, string idEmployee)
        {
            //1027; 537
            add = false;
            this.idEmployee = idEmployee;
            this.name = name;
            this.position = positoin;
            this.permissions = permissions;
            login = form;

            InitializeComponent();

            initGridBuy();

            label1.Visible = false;
            lbPhoneNumber.Visible = false;
            lbCompany.Visible = false;
            lbAddress.Visible = false;
            tbName.Visible = false;
            tbPhoneNumber.Visible = false;
            tbCompany.Visible = false;
            tbAddress.Visible = false;

            lbSize.Visible = false;
            lbDate.Visible = false;
            tbSize.Visible = false;
            dtpEndTime.Visible = false;

            string text = "Server=(local);Initial Catalog=Storage;Trusted_connection=Yes";
            connection = new SqlConnection(text);
        }

        private void MainForm2_Load(object sender, EventArgs e)
        {
            this.Height = 537;

            lbName.Text = name;
            lbPosition.Text = position;

            SQLTasks.getProducts(gridProducts);
            SQLTasks.getProviders(gridProvider);
            SQLTasks.getDiscount(gridDiscount);
            SQLTasks.getStaff(gridStaff);

            //удаление старых скидок
            SQLTasks.deleteOldDiscount();

            cbPosition.Items.Add("Продавец");
            cbPosition.Items.Add("Администратор");
            cbPosition.Items.Add("Директор");

            connection.Open();
            DataTable dataTable = connection.GetSchema("Tables");
            foreach (DataRow dataRow in dataTable.Rows)
            {
                string item = (string)dataRow[2];
                cbTables.Items.Add(item);
            }
            connection.Close();
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

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (gridBuys.Rows.Count == 0)
            {
                MessageBox.Show("Корзина пуста");
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
                    MessageBox.Show("Ошибка. Недостаточно товаров");
                    return;
                }
            }

            //updateProductAmount
            for (int i = 0; i < gridBuys.Rows.Count; i++)
            {
                string key = gridBuys.Rows[i].Cells["Key"].Value.ToString();
                string amount = gridBuys.Rows[i].Cells["Amount"].Value.ToString();
                SQLTasks.updateProductAmount(key, amount);
            }

            SQLTasks.getProducts(gridProducts);

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

                //create listOfProducts
                //Products_id, Selling_id, Amount
                for (int i = 0; i < gridBuys.Rows.Count; i++)
                {
                    SQLTasks.addListOfProducts(
                        gridBuys.Rows[i].Cells["Key"].Value.ToString(),
                        SQLTasks.getMaxSellingId(),
                        gridBuys.Rows[i].Cells["Amount"].Value.ToString());
                }
            }

            //clear buys
            for (int i = gridBuys.Rows.Count - 1; i >= 0; i--)
            {
                gridBuys.Rows.RemoveAt(i);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            login.Show();
        }

        private void btnExit2_Click(object sender, EventArgs e)
        {
            this.Close();
            login.Show();
        }

        private void btnExit3_Click(object sender, EventArgs e)
        {
            this.Close();
            login.Show();
        }

        private void btnSaveProvider_Click(object sender, EventArgs e)
        {
            SQLTasks.updateProviders(gridProvider);
        }

        private void btnCreateProvider_Click(object sender, EventArgs e)
        {
            //1027; 537
            //открытие окна
            if (!add)
            {
                add = true;
                this.Height = 687;
                label1.Visible = true;
                lbPhoneNumber.Visible = true;
                lbCompany.Visible = true;
                lbAddress.Visible = true;
                tbName.Visible = true;
                tbPhoneNumber.Visible = true;
                tbCompany.Visible = true;
                tbAddress.Visible = true;
                return;
            }

            //добавление и закрытые окна
            if (add)
            {
                //TODO
                if (tbName.Text == "" || 
                    tbPhoneNumber.Text == "" || 
                    tbCompany.Text == "" || 
                    tbAddress.Text == "")
                {
                    MessageBox.Show("Ошибка. Заполните все поля");
                    this.Height = 537;
                    add = false;
                    tbName.Text = "";
                    tbPhoneNumber.Text = "";
                    tbCompany.Text = "";
                    tbAddress.Text = "";
                    label1.Visible = false;
                    lbPhoneNumber.Visible = false;
                    lbCompany.Visible = false;
                    lbAddress.Visible = false;
                    tbName.Visible = false;
                    tbPhoneNumber.Visible = false;
                    tbCompany.Visible = false;
                    tbAddress.Visible = false;
                    return;
                }
                else
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
                    this.Height = 537;

                    tbName.Text = "";
                    tbPhoneNumber.Text = "";
                    tbCompany.Text = "";
                    tbAddress.Text = "";
                    label1.Visible = false;
                    lbPhoneNumber.Visible = false;
                    lbCompany.Visible = false;
                    lbAddress.Visible = false;
                    tbName.Visible = false;
                    tbPhoneNumber.Visible = false;
                    tbCompany.Visible = false;
                    tbAddress.Visible = false;
                    return;
                }
            }
        }

        private void btnRemoveProvider_Click(object sender, EventArgs e)
        {
            if (gridProvider.SelectedRows.Count == 0)
            {
                MessageBox.Show("Поставщик не выбран");
                return;
            }

            string selected_name = gridProvider.CurrentRow.Cells["Name"].Value.ToString();
            string selected_phoneNumber = gridProvider.CurrentRow.Cells["PhoneNumber"].Value.ToString();
            string selected_company = gridProvider.CurrentRow.Cells["Company"].Value.ToString();
            string selected_address = gridProvider.CurrentRow.Cells["Address"].Value.ToString();

            SQLTasks.deleteProvider(selected_name, selected_phoneNumber, selected_company, selected_address);
            SQLTasks.getProviders(gridProvider);
        }

        private void btnAddDiscount_Click(object sender, EventArgs e)
        {
            if (!add)
            {
                this.Height = 644;
                add = true;
                lbSize.Visible = true;
                lbDate.Visible = true;
                tbSize.Visible = true;
                dtpEndTime.Visible = true;
                return;
            }

            if (add)
            {
                this.Height = 537;

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

                tbSize.Text = "";
                lbSize.Visible = false;
                lbDate.Visible = false;
                tbSize.Visible = false;
                dtpEndTime.Visible = false;
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

        private void btnUpdateStaff_Click(object sender, EventArgs e)
        {
            SQLTasks.updateStaff(gridStaff);
        }

        private void btnRemoveStaff_Click(object sender, EventArgs e)
        {
            string selected_id = gridStaff.CurrentRow.Cells["Key"].Value.ToString();

            SQLTasks.deleteAuth(selected_id);
            SQLTasks.deleteStaff(selected_id);
            SQLTasks.getStaff(gridStaff);
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            if (!add)
            {
                this.Height = 675;
                add = true;

                return;
            }

            if (add)
            {
                this.Height = 537;

                if (textBox3.Text == "" ||
                    cbPosition.Text == "" ||
                    tbAccrued.Text == "" ||
                    tbEmail.Text == "" ||
                    textBox2.Text == "" ||
                    textBox1.Text == "")
                {
                    MessageBox.Show("Заполните все поля");
                    textBox3.Text = "";
                    tbAccrued.Text = "";
                    tbEmail.Text = "";
                    textBox2.Text = "";
                    textBox1.Text = "";
                    this.Height = 537;
                    return;
                }
                else
                {
                    string name = textBox3.Text;
                    string positoin = cbPosition.Text;
                    string accrued = tbAccrued.Text;
                    string email = tbEmail.Text;
                    string phoneNumber = textBox2.Text;
                    string address = textBox1.Text;

                    SQLTasks.addStaff(name, positoin, accrued, email, phoneNumber, address);
                    SQLTasks.getStaff(gridStaff);
                    MessageBox.Show("Сотрудник добавлен успешно");

                    textBox3.Text = "";
                    tbAccrued.Text = "";
                    tbEmail.Text = "";
                    textBox2.Text = "";
                    textBox1.Text = "";
                }

                add = false;
                return;
            }
        }

        //Delete
        private void tpStaff_Click(object sender, EventArgs e)
        {

        }

        private void btnLoadSearch_Click(object sender, EventArgs e)
        {
            connection.Open();
            DataTable tableResult = new DataTable();
            string table = cbTables.SelectedItem.ToString();
            string column = cbColumns.SelectedItem.ToString();
            string condition = cbCondition.SelectedItem.ToString();

            string query = "select * from " + table
                + " where " + column + " "
                + condition + " " + tbCondition.Text;   //Replace("'", "''")

            Console.WriteLine(query);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
            dataAdapter.Fill(tableResult);
            gridResult.DataSource = tableResult;
            connection.Close();
        }

        private void cbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbColumns.Items.Clear();

            //Console.WriteLine(cbTables.SelectedItem);
            string tableName = cbTables.SelectedItem.ToString();

            connection.Open();
            DataTable table = new DataTable();
            string query = "select top 0 * from " + tableName;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
            dataAdapter.Fill(table);
            foreach (DataColumn column in table.Columns)
            {
                cbColumns.Items.Add(column.ColumnName);
            }
            connection.Close();
        }
    }
}
