namespace ListaDeCompras.Model
{
    public class Casa
    {

        public Casa()
        {
        }

        public Casa(string apelido, string endereco, double qtdMoradores, double renda, DateTime dtRenovacao)
        {
            Apelido = apelido;
            Endereco = endereco;
            QtdMoradores = qtdMoradores;
            Renda = renda;
            DtRenovacao = dtRenovacao;
        }
        public string Apelido { get; set; }
        public string Endereco { get; set; }
        public double QtdMoradores { get; set; }
        public double Renda { get; set; }
        public DateTime DtRenovacao { get; set; }
    }
}