using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DBProject_tele_company_.DB
{
    internal class DBConection
    {
        static string DBConect = "server = localhost; user=root; password=12345; database=tele-company";
        static public MySqlDataAdapter MySqlDataAdapter;
        static MySqlConnection MySqlConnection;
        static public MySqlCommand MySqlCommand;

        public static bool ConectionDB()
        {
            try
            {
                MySqlConnection = new MySqlConnection(DBConect);
                MySqlConnection.Open();
                MySqlCommand = new MySqlCommand();
                MySqlCommand.Connection = MySqlConnection;
                MySqlDataAdapter = new MySqlDataAdapter(MySqlCommand);
                return true;
            }
            catch 
            {
                MessageBox.Show("Помилка з'єднання з БД", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static void CloseDB()
        {
            MySqlConnection.Close();
        }

        public static MySqlConnection getConnection()
        {
            return MySqlConnection;
        }
    }
}
