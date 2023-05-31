using ListaDeCompras.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeCompras.Controller
{
    internal class ProdutoController
    {
        public void cadastrar(string codigo, string nome, string marca, double valor, DateTime dtRegistro)
        {
            DatabaseConnection connection = new DatabaseConnection();
            ProdutoDAO produtoDAO = new ProdutoDAO(connection);
            MessageBox.Show("Conctado no banco");
            Produto produto = new Produto(codigo, nome, marca, valor, dtRegistro);

            bool result = produtoDAO.inserir(produto);

            if (!result)
            {
                MessageBox.Show("Erro no cadastro");
            }
            else
            {
                MessageBox.Show("Cadastrado com sucesso");
            }

        }

        public List<Produto> listar()
        {
            DatabaseConnection connection = new DatabaseConnection();
            ProdutoDAO produtoDAO = new ProdutoDAO(connection);
            return produtoDAO.listar();
        }
    }
}
