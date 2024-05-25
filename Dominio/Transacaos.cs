namespace Dominio
{
    public class Transacaos
    {
        private int codigo;
        private int quantidade;
        private double valor;
        private string data;
        private string cliente;
        private string motivo;

        public int Codigo { get => codigo; set => codigo = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public double Valor { get => valor; set => valor = value; }
        public string Data { get => data; set => data = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public string Motivo { get => motivo; set => motivo = value; }

        public Transacaos(int codigo, int quantidade, double valor, string data, string cliente, string motivo)
        {
            if (codigo < 1) throw new ArgumentException("Código inválido");
            this.codigo = codigo;
            this.quantidade = quantidade;
            this.valor = valor;
            this.data = data;
            this.cliente = cliente;
            this.motivo = motivo;
        }
    }
}