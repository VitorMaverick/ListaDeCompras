using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeCompras.Model
{
    internal class CasaDAO
    {
        private DatabaseConnection _connection;

        public CasaDAO(DatabaseConnection connection)
        {
            _connection = connection;
        }

        public bool inserir(Casa casa)
        {
            _connection.Open();
            string query = "INSERT INTO casa (Apelido, Endereco, QtdMoradores, Renda, DtRenovacao) VALUES (@Apelido, @Endereco, @QtdMoradores, @Renda, @DtRenovacao)";
            bool result = false;
            MySqlCommand command = new MySqlCommand(query, _connection.GetConnection());
            command.Parameters.AddWithValue("@Apelido", casa.Apelido);
            command.Parameters.AddWithValue("@Endereco", casa.Endereco);
            command.Parameters.AddWithValue("@QtdMoradores", casa.QtdMoradores);
            command.Parameters.AddWithValue("@Renda", casa.Renda);
            command.Parameters.AddWithValue("@DtRenovacao", casa.DtRenovacao);

            MessageBox.Show($"Apelido: {casa.Apelido}, endereco {casa.Endereco}, qtd moradores, {casa.QtdMoradores}, renda {casa.Renda} Dtrenovacao{casa.DtRenovacao}");
            int queruResult = command.ExecuteNonQuery();
            if (Convert.ToBoolean(queruResult) == true)
            {
                result = true;
            }
            
            _connection.Close();
            return result;
            
        }

        public List<Casa> listar()
        {
            _connection.Open();
            List<Casa> casas = new List<Casa>();
            string query = "SELECT * FROM casa";
            MySqlCommand command = new MySqlCommand(query, _connection.GetConnection());
            MySqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                Casa casa = new Casa();
                casa.Apelido = (string)reader["Apelido"];
                casa.Endereco =(string) reader["Endereco"];
                casa.QtdMoradores = (double)reader["QtdMoradores"];
                casa.DtRenovacao = (DateTime)reader["DtRenovacao"];

                casas.Add(casa);
            }

            reader.Close();
            _connection.Close();

            return casas;
        }
        
    }
}
