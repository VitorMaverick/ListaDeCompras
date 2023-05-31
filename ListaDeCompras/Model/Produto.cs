namespace ListaDeCompras.Model
{
    public class Produto
    {
        public Produto()
        {
        }

        public Produto(string codigo, string nome, string marca, double valor, DateTime dtRegistro)
        {
            Codigo = codigo;
            Nome = nome;
            Marca = marca;
            Valor = valor;
            DtRegistro = dtRegistro;
        }

        public object? Codigo { get; internal set; }
        public object? Nome { get; internal set; }
        public object? Marca { get; internal set; }
        public object? Valor { get; internal set; }
        public object? DtRegistro { get; internal set; }
    }
}