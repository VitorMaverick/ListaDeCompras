using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace ListaDeCompras.Model
{
    internal class DatabaseConnection
    {
        private MySqlConnection connection;
        public DatabaseConnection() {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                UserID = "root",
                Password = "senha",
                Database = "dblistadecompras",
            };
            this.connection = new MySqlConnection(builder.ConnectionString);
        }
        public MySqlConnection GetConnection()
        {
            return connection;
        }

        public void Open()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void Close()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
    }
}
