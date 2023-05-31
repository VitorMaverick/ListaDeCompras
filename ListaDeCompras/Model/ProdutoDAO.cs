using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeCompras.Model
{
    internal class ProdutoDAO
    {
        DatabaseConnection databaseConnection = new DatabaseConnection();
        public ProdutoDAO(DatabaseConnection connection) { 
            databaseConnection = connection;
        }

        public bool inserir(Produto produto)
        {
            _connection.Open();
            string query = "INSERT INTO produto (Apelido, Endereco, QtdMoradores, Renda, DtRenovacao) VALUES (@Apelido, @Endereco, @QtdMoradores, @Renda, @DtRenovacao)";
            bool result = false;
            MySqlCommand command = new MySqlCommand(query, _connection.GetConnection());
            command.Parameters.AddWithValue("@Renda", produto.Codigo);
            command.Parameters.AddWithValue("@Apelido", produto.Nome);
            command.Parameters.AddWithValue("@Endereco", produto.Marca);
            command.Parameters.AddWithValue("@QtdMoradores", produto.Valor);
            command.Parameters.AddWithValue("@DtRenovacao", produto.DtRegistro);

            MessageBox.Show($"Apelido: {produto.Apelido}, endereco {produto.Endereco}, qtd moradores, {produto.QtdMoradores}, renda {produto.Renda} Dtrenovacao{produto.DtRenovacao}");
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
            string query = "SELECT * FROM produto";
            MySqlCommand command = new MySqlCommand(query, _connection.GetConnection());
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Casa casa = new Casa();
                casa.Apelido = (string)reader["Apelido"];
                casa.Endereco = (string)reader["Endereco"];
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
