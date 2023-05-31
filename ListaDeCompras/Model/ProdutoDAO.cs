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
        private DatabaseConnection _connection = new DatabaseConnection();
        public ProdutoDAO(DatabaseConnection connection) => _connection = connection;

        public bool inserir(Produto produto)
        {
            _connection.Open();
            string query = "INSERT INTO produto (Nome, Marca, Valor, Codigo, DtRegistro) VALUES (@Nome, @Marca, @Valor, @Codigo, @DtRegistro)";
            bool result = false;
            MySqlCommand command = new MySqlCommand(query, _connection.GetConnection());
            command.Parameters.AddWithValue("@Codigo", produto.Codigo);
            command.Parameters.AddWithValue("@Nome", produto.Nome);
            command.Parameters.AddWithValue("@Marca", produto.Marca);
            command.Parameters.AddWithValue("@Valor", produto.Valor);
            command.Parameters.AddWithValue("@DtRegistro", produto.DtRegistro);

            int queruResult = command.ExecuteNonQuery();
            if (Convert.ToBoolean(queruResult) == true)
            {
                result = true;
            }

            _connection.Close();
            return result;

        }

        public List<Produto> listar()
        {
            _connection.Open();
            List<Produto> produtos = new List<Produto>();
            string query = "SELECT * FROM produto";
            MySqlCommand command = new MySqlCommand(query, _connection.GetConnection());
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Produto produto = new Produto();
                produto.Nome = (string)reader["Nome"];
                produto.Marca = (string)reader["Marca"];
                produto.Valor = (double)reader["Valor"];
                produto.DtRegistro = (DateTime)reader["DtRegistro"];

                produtos.Add(produto);
            }

            reader.Close();
            _connection.Close();

            return produtos;
        }
    }
}
