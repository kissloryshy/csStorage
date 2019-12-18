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

namespace Storage
{
    public partial class Const : Form
    {
        private static SqlConnection connection;

        public Const()
        {
            InitializeComponent();

            string text = "Server=(local);Initial Catalog=Storage;Trusted_connection=Yes";
            connection = new SqlConnection(text);
        }

        private void Const_Load(object sender, EventArgs e)
        {
            connection.Open();
            DataTable dataTable = connection.GetSchema("Tables");
            foreach (DataRow dataRow in dataTable.Rows)
            {
                string item = (string)dataRow[2];
                cbTables.Items.Add(item);
            }
            connection.Close();
        }

        private void cbTables_SelectedValueChanged(object sender, EventArgs e)
        {
            cbColumns.Items.Clear();

            //Console.WriteLine(cbTables.SelectedItem);
            string tableName = cbTables.SelectedItem.ToString();

            connection.Open();
            DataTable table = new DataTable();
            string query = "select top 0 * from " + tableName;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
            dataAdapter.Fill(table);
            foreach(DataColumn column in table.Columns)
            {
                cbColumns.Items.Add(column.ColumnName);
            }
            connection.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
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

            //    MessageBox.Show("Ошибка ввода выражения");
        }
    }
}
