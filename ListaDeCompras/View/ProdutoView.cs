using ListaDeCompras.Controller;
using ListaDeCompras.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDeCompras.View
{
    public partial class ProdutoView : Form
    {
        public ProdutoView()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string codigo = txbCodigo.Text;
            string nome = TxbNome.Text;
            string marca = txbMarca.Text;
            double valor = (double)numericValor.Value;
            DateTime dtRegistro = DateTime.Now;

            ProdutoController controller = new ProdutoController();
            controller.cadastrar(codigo, nome, marca, valor, dtRegistro);

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ProdutoController controller = new ProdutoController();
            List<Produto> produtos = controller.listar();
            dataGridViewProduto.DataSource = produtos;
        }
    }
}
