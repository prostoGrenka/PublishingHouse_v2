using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PublishingHouse
{
    internal class ConnectionDbForUser
    {
        public SqlConnection Connection()
        {
            string connectionString = "Data Source = DESKTOP-N8GPQUA;Initial Catalog = User;Integrated Security = True";

            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                Console.WriteLine("Подключение выполнено");
            }
            catch
            {
                Console.WriteLine(MessageBox.Show("Ошибка подключения"));
            }


            return connection;
        }
        public SqlConnection Close()
        {
            SqlConnection con = Connection();
            con.Close();
            Console.WriteLine("Подключение закрыто");
            return con;
        }

    }
}
