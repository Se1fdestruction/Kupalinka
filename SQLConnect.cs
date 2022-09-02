using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Kupalinka
{
    public class SQLConnect
    {


        //  static string connectionString = "Server="+Properties.Settings.Default.server+","+ Properties.Settings.Default.port + ";Database="+ Properties.Settings.Default.database+ ";User Id="+ Properties.Settings.Default.user + ";Password="+ Properties.Settings.Default.pass + ";";

      //  static string connectionString = @"Server=KKV;Database=kupalinka99; Integrated Security=true";
      static string connectionString = @"Server=192.155.11.25,1433;Database=kupalinka99;User=admin;Password=159963 ";


        // Создание подключения
        SqlConnection connection = new SqlConnection(connectionString);
        SqlCommand comand;
        public DataTable Execute_read(string Command)
        {
            DataTable dt = null;
            if (connection != null)
            {
                try
                {
                    connection.Open();
                    dt = new DataTable();
                    comand = connection.CreateCommand();
                    comand.CommandText = Command;
                    dt.Load(comand.ExecuteReader());
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return dt;

        }

        public void Execute_write(string Command)
        {

            if (connection != null)
            {
                try
                {
                    connection.Open();
                    comand = connection.CreateCommand();
                    comand.CommandText = Command;
                    comand.ExecuteReader();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

    }
}
