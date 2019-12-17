using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Storage
{
    class SQLTasks
    {
        private static SqlConnection connection;

        private static string login;
        private static string password;

        private static DataSet ds;
        private static SqlDataAdapter da;
        private static SqlCommandBuilder cmdbuilder;

        //Обновить 
        private static void clearGlogals()
        {
            //ds = new DataSet();
            //da = new SqlDataAdapter();
            //cmdbuilder = new SqlCommandBuilder();
        }

        //подключение к бд
        public static void SQLConnect()
        {
            string text = "Server=(local);Initial Catalog=Storage;Trusted_connection=Yes";
            connection = new SqlConnection(text);
            connection.Open();

            Console.WriteLine(connection.State.ToString());
            Console.WriteLine(connection.DataSource);
            Console.WriteLine(connection.ServerVersion);

            connection.Close();
        }

        //проверка логина и пароля и возврат прав
        public static string verify(String login, String password)
        {
            SQLTasks.login = login;
            SQLTasks.password = password;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "getPermissions";
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "@login";
            parameter.SqlDbType = SqlDbType.VarChar;
            parameter.Size = 100;
            parameter.Direction = ParameterDirection.Input;
            parameter.Value = login;
            command.Parameters.Add(parameter);

            parameter = new SqlParameter();
            parameter.ParameterName = "@password";
            parameter.SqlDbType = SqlDbType.VarChar;
            parameter.Size = 100;
            parameter.Direction = ParameterDirection.Input;
            parameter.Value = password;
            command.Parameters.Add(parameter);

            parameter = new SqlParameter();
            parameter.ParameterName = "@permissions";
            parameter.SqlDbType = SqlDbType.VarChar;
            parameter.Size = 500;
            parameter.Direction = ParameterDirection.Output;
            parameter.Value = "-111";
            command.Parameters.Add(parameter);

            parameter = new SqlParameter();
            parameter.ParameterName = "@employersName";
            parameter.SqlDbType = SqlDbType.VarChar;
            parameter.Size = 255;
            parameter.Direction = ParameterDirection.Output;
            parameter.Value = "-111";
            command.Parameters.Add(parameter);

            parameter = new SqlParameter();
            parameter.ParameterName = "@position";
            parameter.SqlDbType = SqlDbType.VarChar;
            parameter.Size = 255;
            parameter.Direction = ParameterDirection.Output;
            parameter.Value = "13";
            command.Parameters.Add(parameter);

            parameter = new SqlParameter();
            parameter.ParameterName = "@idEmployee";
            parameter.SqlDbType = SqlDbType.Int;
            parameter.Size = 255;
            parameter.Direction = ParameterDirection.Output;
            parameter.Value = -1;
            command.Parameters.Add(parameter);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            Console.WriteLine("idEmployee = " + command.Parameters["@idEmployee"].Value);
            Console.WriteLine("employersName = " + command.Parameters["@employersName"].Value);
            Console.WriteLine("position = " + command.Parameters["@position"].Value);
            Console.WriteLine("permissions = " + command.Parameters["@permissions"].Value);

            string idEmployee = Convert.ToString(command.Parameters["@idEmployee"].Value);
            string name = Convert.ToString(command.Parameters["@employersName"].Value);
            string position = Convert.ToString(command.Parameters["@position"].Value);
            string permissions = Convert.ToString(command.Parameters["@permissions"].Value);

            return idEmployee + ';' + name + ';' + position + ';' + permissions;
        }
        
        public static string getEmployeeInfo()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "getEmployeeInfo";
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "@login";
            parameter.SqlDbType = SqlDbType.VarChar;
            parameter.Size = 100;
            parameter.Direction = ParameterDirection.Input;
            parameter.Value = SQLTasks.login;
            command.Parameters.Add(parameter);

            parameter = new SqlParameter();
            parameter.ParameterName = "@password";
            parameter.SqlDbType = SqlDbType.VarChar;
            parameter.Size = 100;
            parameter.Direction = ParameterDirection.Input;
            parameter.Value = SQLTasks.password;
            command.Parameters.Add(parameter);

            parameter = new SqlParameter();
            parameter.ParameterName = "@email";
            parameter.SqlDbType = SqlDbType.VarChar;
            parameter.Size = 255;
            parameter.Direction = ParameterDirection.Output;
            parameter.Value = "-1";
            command.Parameters.Add(parameter);

            parameter = new SqlParameter();
            parameter.ParameterName = "@phoneNumber";
            parameter.SqlDbType = SqlDbType.VarChar;
            parameter.Size = 255;
            parameter.Direction = ParameterDirection.Output;
            parameter.Value = "-1";
            command.Parameters.Add(parameter);

            parameter = new SqlParameter();
            parameter.ParameterName = "@address";
            parameter.SqlDbType = SqlDbType.VarChar;
            parameter.Size = 255;
            parameter.Direction = ParameterDirection.Output;
            parameter.Value = "-1";
            command.Parameters.Add(parameter);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            string email = Convert.ToString(command.Parameters["@email"].Value);
            string phoneNumber = Convert.ToString(command.Parameters["@phoneNumber"].Value);
            string address = Convert.ToString(command.Parameters["@address"].Value);

            //Console.WriteLine(email);
            //Console.WriteLine(password);
            //Console.WriteLine(address);

            return email + ";" + phoneNumber + ";" + address;
        }

        public static bool updateEmployeeInfo(string raw)
        {
            Console.WriteLine(raw);
            string[] info = raw.Split(';');

            string email = info[0];
            string phoneNumber = info[1];
            string address = info[2];

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "updateEmployeeInfo";
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "@login";
            parameter.SqlDbType = SqlDbType.VarChar;
            parameter.Size = 100;
            parameter.Direction = ParameterDirection.Input;
            parameter.Value = SQLTasks.login;
            command.Parameters.Add(parameter);

            parameter = new SqlParameter();
            parameter.ParameterName = "@password";
            parameter.SqlDbType = SqlDbType.VarChar;
            parameter.Size = 100;
            parameter.Direction = ParameterDirection.Input;
            parameter.Value = SQLTasks.password;
            command.Parameters.Add(parameter);

            parameter = new SqlParameter();
            parameter.ParameterName = "@email";
            parameter.SqlDbType = SqlDbType.VarChar;
            parameter.Size = 255;
            parameter.Direction = ParameterDirection.Input;
            parameter.Value = email;
            command.Parameters.Add(parameter);

            parameter = new SqlParameter();
            parameter.ParameterName = "@phoneNumber";
            parameter.SqlDbType = SqlDbType.VarChar;
            parameter.Size = 255;
            parameter.Direction = ParameterDirection.Input;
            parameter.Value = phoneNumber;
            command.Parameters.Add(parameter);

            parameter = new SqlParameter();
            parameter.ParameterName = "@address";
            parameter.SqlDbType = SqlDbType.VarChar;
            parameter.Size = 255;
            parameter.Direction = ParameterDirection.Input;
            parameter.Value = address;
            command.Parameters.Add(parameter);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            return true;
        }

        public static void getProducts(DataGridView gridProducts)
        {
            SqlCommand cmd = new SqlCommand("getProducts", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "Products");
            gridProducts.DataSource = ds.Tables[0];
        }

        public static void getProviders(DataGridView gridProvider)
        {
            SqlCommand cmd = new SqlCommand("getProviders", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "Providers");
            gridProvider.DataSource = ds.Tables[0];
        }

        public static void getStaff(DataGridView gridStaff)
        {
            SqlCommand cmd = new SqlCommand("getStaff", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "Employers");
            gridStaff.DataSource = ds.Tables[0];
        }

        public static void getDiscount(DataGridView gridDiscount)
        {
            SqlCommand cmd = new SqlCommand("getDiscount", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "Discount");
            gridDiscount.DataSource = ds.Tables[0];
        }

        public static List<string> getPositions()
        {
            SqlCommand cmd = new SqlCommand("getPositions", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "Employers");

            List<string> positions = new List<string>();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                positions.Add(ds.Tables[0].Rows[i]["Position"].ToString());
            }

            return positions;
        }

        public static int getProductAmount(string key, string amount)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "getProductAmount";
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "@Key";
            parameter.SqlDbType = SqlDbType.Int;
            parameter.Direction = ParameterDirection.Input;
            parameter.Value = key;
            command.Parameters.Add(parameter);

            parameter = new SqlParameter();
            parameter.ParameterName = "@amount";
            parameter.SqlDbType = SqlDbType.Int;
            parameter.Direction = ParameterDirection.Input;
            parameter.Value = amount;
            command.Parameters.Add(parameter);

            parameter = new SqlParameter();
            parameter.ParameterName = "@amountOut";
            parameter.SqlDbType = SqlDbType.Int;
            parameter.Direction = ParameterDirection.Output;
            parameter.Value = -1;
            command.Parameters.Add(parameter);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            return Convert.ToInt32(command.Parameters["@amountOut"].Value);
        }

        public static void getCustomer(DataGridView gridCustomer)
        {
            SqlCommand cmd = new SqlCommand("getCustomer", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "Products");
            gridCustomer.DataSource = ds.Tables[0];
        }

        public static string getMaxSellingId()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "getMaxSellingId";
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "@key";
            parameter.SqlDbType = SqlDbType.Int;
            parameter.Direction = ParameterDirection.Output;
            parameter.Value = -1;
            command.Parameters.Add(parameter);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            return command.Parameters["@key"].Value.ToString();
        }

        public static void addProvider(string name, string phoneNumber, string company, string address)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "addProvider";
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "@Name";
            parameter.SqlDbType = SqlDbType.VarChar;
            parameter.Size = 255;
            parameter.Direction = ParameterDirection.Input;
            parameter.Value = name;
            command.Parameters.Add(parameter);

            parameter = new SqlParameter();
            parameter.ParameterName = "@PhoneNumber";
            parameter.SqlDbType = SqlDbType.VarChar;
            parameter.Size = 255;
            parameter.Direction = ParameterDirection.Input;
            parameter.Value = phoneNumber;
            command.Parameters.Add(parameter);

            parameter = new SqlParameter();
            parameter.ParameterName = "@Company";
            parameter.SqlDbType = SqlDbType.VarChar;
            parameter.Size = 255;
            parameter.Direction = ParameterDirection.Input;
            parameter.Value = company;
            command.Parameters.Add(parameter);

            parameter = new SqlParameter();
            parameter.ParameterName = "@address";
            parameter.SqlDbType = SqlDbType.VarChar;
            parameter.Size = 255;
            parameter.Direction = ParameterDirection.Input;
            parameter.Value = address;
            command.Parameters.Add(parameter);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static void addStaff(string name, string position, string accrued, string email, string phoneNumber, string address)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "addStaff";
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "@Name";
            parameter.SqlDbType = SqlDbType.VarChar;
            parameter.Size = 255;
            parameter.Direction = ParameterDirection.Input;
            parameter.Value = name;
            command.Parameters.Add(parameter);

            parameter = new SqlParameter();
            parameter.ParameterName = "@Position";
            parameter.SqlDbType = SqlDbType.VarChar;
            parameter.Size = 255;
            parameter.Direction = ParameterDirection.Input;
            parameter.Value = position;
            command.Parameters.Add(parameter);

            parameter = new SqlParameter();
            parameter.ParameterName = "@Accrued";
            parameter.SqlDbType = SqlDbType.VarChar;
            parameter.Size = 255;
            parameter.Direction = ParameterDirection.Input;
            parameter.Value = accrued;
            command.Parameters.Add(parameter);

            parameter = new SqlParameter();
            parameter.ParameterName = "@Email";
            parameter.SqlDbType = SqlDbType.VarChar;
            parameter.Size = 255;
            parameter.Direction = ParameterDirection.Input;
            parameter.Value = email;
            command.Parameters.Add(parameter);

            parameter = new SqlParameter();
            parameter.ParameterName = "@PhoneNumber";
            parameter.SqlDbType = SqlDbType.VarChar;
            parameter.Size = 255;
            parameter.Direction = ParameterDirection.Input;
            parameter.Value = phoneNumber;
            command.Parameters.Add(parameter);

            parameter = new SqlParameter();
            parameter.ParameterName = "@address";
            parameter.SqlDbType = SqlDbType.VarChar;
            parameter.Size = 255;
            parameter.Direction = ParameterDirection.Input;
            parameter.Value = address;
            command.Parameters.Add(parameter);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static void addDiscount(string size, string endDate)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "addDiscount";
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "@size";
            parameter.SqlDbType = SqlDbType.VarChar;
            parameter.Direction = ParameterDirection.Input;
            parameter.Value = size;
            command.Parameters.Add(parameter);

            parameter = new SqlParameter();
            parameter.ParameterName = "@endDate";
            parameter.SqlDbType = SqlDbType.DateTime;
            parameter.Direction = ParameterDirection.Input;
            parameter.Value = endDate;
            command.Parameters.Add(parameter);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static void addSelling(int customer, int seller)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "addSelling";
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "@customer";
            parameter.SqlDbType = SqlDbType.Int;
            parameter.Direction = ParameterDirection.Input;
            parameter.Value = customer;
            command.Parameters.Add(parameter);

            parameter = new SqlParameter();
            parameter.ParameterName = "@seller";
            parameter.SqlDbType = SqlDbType.Int;
            parameter.Direction = ParameterDirection.Input;
            parameter.Value = seller;
            command.Parameters.Add(parameter);

            parameter = new SqlParameter();
            parameter.ParameterName = "@date";
            parameter.SqlDbType = SqlDbType.DateTime;
            parameter.Direction = ParameterDirection.Input;
            parameter.Value = DateTime.Now;
            command.Parameters.Add(parameter);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static void addListOfProducts(string product_id, string selling_id, string amount)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "addListOfProducts";
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "@productId";
            parameter.SqlDbType = SqlDbType.Int;
            //parameter.Size = 255;
            parameter.Direction = ParameterDirection.Input;
            parameter.Value = product_id;
            command.Parameters.Add(parameter);

            parameter = new SqlParameter();
            parameter.ParameterName = "@sellingId";
            parameter.SqlDbType = SqlDbType.Int;
            //parameter.Size = 255;
            parameter.Direction = ParameterDirection.Input;
            parameter.Value = selling_id;
            command.Parameters.Add(parameter);

            parameter = new SqlParameter();
            parameter.ParameterName = "@amount";
            parameter.SqlDbType = SqlDbType.Int;
            //parameter.Size = 255;
            parameter.Direction = ParameterDirection.Input;
            parameter.Value = amount;
            command.Parameters.Add(parameter);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static void updateProviders(DataGridView gridProvider)
        {
            cmdbuilder = new SqlCommandBuilder(da);
            try
            {
                da.Update(ds, "Providers");
                getProviders(gridProvider);
                MessageBox.Show("Данные успешно обновлены");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                clearGlogals();
            }
        }

        public static void updateProducts(DataGridView gridProducts)
        {
            cmdbuilder = new SqlCommandBuilder(da);
            da.Update(ds, "Products");
            getProducts(gridProducts);
            try
            {
                
                MessageBox.Show("Данные успешно обновлены");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                clearGlogals();
            }
        }

        public static void updateStaff(DataGridView gridStaff)
        {
            cmdbuilder = new SqlCommandBuilder(da);
            try
            {
                da.Update(ds, "Employers");
                getStaff(gridStaff);
                MessageBox.Show("Данные успешно обновлены");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                clearGlogals();
            }
        }

        public static void updateProductAmount(string key, string amount)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "updateProductAmount";
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "@Key";
            parameter.SqlDbType = SqlDbType.Int;
            parameter.Direction = ParameterDirection.Input;
            parameter.Value = key;
            command.Parameters.Add(parameter);

            parameter = new SqlParameter();
            parameter.ParameterName = "@amount";
            parameter.SqlDbType = SqlDbType.Int;
            parameter.Direction = ParameterDirection.Input;
            parameter.Value = amount;
            command.Parameters.Add(parameter);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static void deleteProvider(string name, string phoneNumber, string company, string address)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "deleteProvider";
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "@Name";
            parameter.SqlDbType = SqlDbType.VarChar;
            parameter.Size = 255;
            parameter.Direction = ParameterDirection.Input;
            parameter.Value = name;
            command.Parameters.Add(parameter);

            parameter = new SqlParameter();
            parameter.ParameterName = "@PhoneNumber";
            parameter.SqlDbType = SqlDbType.VarChar;
            parameter.Size = 255;
            parameter.Direction = ParameterDirection.Input;
            parameter.Value = phoneNumber;
            command.Parameters.Add(parameter);

            parameter = new SqlParameter();
            parameter.ParameterName = "@Company";
            parameter.SqlDbType = SqlDbType.VarChar;
            parameter.Size = 255;
            parameter.Direction = ParameterDirection.Input;
            parameter.Value = company;
            command.Parameters.Add(parameter);

            parameter = new SqlParameter();
            parameter.ParameterName = "@address";
            parameter.SqlDbType = SqlDbType.VarChar;
            parameter.Size = 255;
            parameter.Direction = ParameterDirection.Input;
            parameter.Value = address;
            command.Parameters.Add(parameter);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static void deleteStaff(string key)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "deleteStaff";
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "@Key";
            parameter.SqlDbType = SqlDbType.Int;
            //parameter.Size = 255;
            parameter.Direction = ParameterDirection.Input;
            parameter.Value = key;
            command.Parameters.Add(parameter);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static void deleteAuth(string key)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "deleteAuth";
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "@Key";
            parameter.SqlDbType = SqlDbType.Int;
            //parameter.Size = 255;
            parameter.Direction = ParameterDirection.Input;
            parameter.Value = key;
            command.Parameters.Add(parameter);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static void deleteDiscount(string key)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "deleteDiscount";
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "@Key";
            parameter.SqlDbType = SqlDbType.Int;
            parameter.Direction = ParameterDirection.Input;
            parameter.Value = key;
            command.Parameters.Add(parameter);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static void deleteOldDiscount()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "deleteOldDiscount";
            command.CommandType = CommandType.StoredProcedure;

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            Console.WriteLine("старые скидки были удалены");
        }
    }
}
