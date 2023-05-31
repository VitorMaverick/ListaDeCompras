using ListaDeCompras.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeCompras.Controller
{
    internal class CasaController
    {
        public void cadastrarCasa(string apelido, string endereco, double qtdMoradores, double renda, DateTime dtRenovacao)
        {
            DatabaseConnection connection = new DatabaseConnection();
            CasaDAO casaDAO = new CasaDAO(connection);
            MessageBox.Show("Conctado no banco");
            Casa casa = new Casa(apelido, endereco, qtdMoradores, renda, dtRenovacao);

            bool result = casaDAO.inserir(casa);

            if(!result)
            {
                MessageBox.Show("Erro no cadastro");
            }else
            {
                MessageBox.Show("Cadastrado com sucesso");
            }
            
        }

        public List<Casa> listar()
        {
            DatabaseConnection connection = new DatabaseConnection();
            CasaDAO casaDAO = new CasaDAO(connection);
            return casaDAO.listar();
        }

    }
}
