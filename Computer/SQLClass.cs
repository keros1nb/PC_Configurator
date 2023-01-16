using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.IO;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;
using System.Windows.Forms;

namespace Computer
{
   public static class SQLClass
    {

        public const string CONNECTION_STRING =
           "SslMode=none;Server=localhost;Database=Computer;port=3306;Uid=root;charset=utf8";

        public static MySqlConnection CONN;

        public static List<string> Select(string cmdText)
        {
            List<string> list = new List<string>();
            try
            {

                MySqlCommand cmd = new MySqlCommand(cmdText, SQLClass.CONN);
                DbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        list.Add(reader.GetValue(i).ToString());
                    }

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                if (!File.Exists(Path.GetTempPath() + "/Errors_logs"))

                    File.Create(Path.GetTempPath() + "/Errors_logs");

                File.AppendAllText(Path.GetTempPath() + "/Errors_logs", "Ошибка" + Environment.NewLine +
                    DateTime.Now.ToString() + " " + ex.Message + " " + cmdText + Environment.NewLine + Environment.NewLine);

                MessageBox.Show("Error");
            }
            return list;
        }

        //summary
        //функция Update запроса /Insert/Delete
        // </summary>
        public static void Update(string cmdText)
        {
            MySqlCommand cmd = new MySqlCommand(cmdText, SQLClass.CONN);
            DbDataReader reader = cmd.ExecuteReader();
            reader.Close();
        }

        


    }
}

