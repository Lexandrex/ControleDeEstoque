namespace Dominio
{
    public class Transacaoe
    {
        private int codigo;
        private int quantidade;
        private double valor;
        private string data;
        private string forncedor;
        private string fatura;
        private string motivo;

        public int Codigo { get => codigo; set => codigo = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public double Valor { get => valor; set => valor = value; }
        public string Data{ get => data; set => data = value; }
        public string Forncedor { get => forncedor; set => forncedor = value; }
        public string Fatura { get => fatura; set => fatura = value; }
        public string Motivo { get => motivo; set => motivo = value; }

        public Transacaoe(int codigo, int quantidade, double valor, string data, string forncedor, string fatura, string motivo)
        {
            if (codigo < 1) throw new ArgumentException("Código inválido");
            this.codigo = codigo;
            this.quantidade = quantidade;
            this.valor = valor;
            this.data = data;
            this.forncedor = forncedor;
            this.fatura = fatura;
            this.motivo = motivo;
        }
    }
}