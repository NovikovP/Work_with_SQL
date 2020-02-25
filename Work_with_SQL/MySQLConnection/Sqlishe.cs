using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQLConnection
{
    class Sqlishe
    {
        public static string run_mysql(string sql)
        {
            string result = "1";
            try
            {

                string myConnectionString = "Database=" + Hranilishe.MySql_Base + ";Data Source=" + Hranilishe.MySql_Server + ";User Id=" + Hranilishe.MySql_User + ";Password=" + Hranilishe.MySql_Pass + "";
                MySqlConnection myConnection = new MySqlConnection(myConnectionString);
                MySqlCommand myCommand = new MySqlCommand(sql);
                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myConnection.Close();
            }
            catch
            {
                result = "0";//Вернёт 0 - если ошибка!
            }
            return result;
        }




        public static string run_mysql_return(string sql)
        {
            string result = "0";
            try
            {

                string myConnectionString = "Database=" + Hranilishe.MySql_Base + ";Data Source=" + Hranilishe.MySql_Server + ";User Id=" + Hranilishe.MySql_User + ";Password=" + Hranilishe.MySql_Pass + "";
                MySqlConnection myConnection = new MySqlConnection(myConnectionString);
                MySqlCommand myCommand = new MySqlCommand(sql);
                myCommand.Connection = myConnection;
                myConnection.Open();
                result = myCommand.ExecuteScalar().ToString();
                myConnection.Close();
            }
            catch
            {
                result = "0";//Вернёт 0 - если ошибка!
            }
            return result;
        }

    }
}
