using ListaDeCompras.Controller;
using ListaDeCompras.Model;

namespace ListaDeCompras
{
    public partial class CasaView : Form
    {
        public CasaView()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarCasa_Click(object sender, EventArgs e)
        {
            string Apelido = txtApelido.Text;
            string Endereco = txtEndereco.Text;
            double QtdMoradores = (double)numericQtdMoradores.Value;
            double Renda = (double)numericRenda.Value;
            DateTime DtRenovacao = dateTimeDtRenovacao.Value;

            CasaController controller = new CasaController();
            controller.cadastrarCasa(Apelido, Endereco, QtdMoradores, Renda, DtRenovacao);


        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string Apelido = txtApelido.Text;
            string Endereco = txtEndereco.Text;
            double QtdMoradores = (double)numericQtdMoradores.Value;
            double Renda = (double)numericRenda.Value;
            DateTime DtRenovacao = dateTimeDtRenovacao.Value;

            CasaController controller = new CasaController();
            controller.cadastrarCasa(Apelido, Endereco, QtdMoradores, Renda, DtRenovacao);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            CasaController controller = new CasaController();
            List<Casa> casas = controller.listar();
            dataGridViewCasas.DataSource = casas;
        }
    }
}