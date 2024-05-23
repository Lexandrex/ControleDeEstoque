namespace Dominio
{
    public class Produtos
    {
        private string descricao;
        private int codbarras;
        private double precovenda;
        private double precocompra;
        private int estoque;
        private string categoria;
        private string fornecedor;

        public string Descricao { get => descricao; set => descricao = value; }
        public int Codbarras { get => codbarras; set => codbarras = value; }
        public double Precovenda { get => precovenda; set => precovenda = value; }
        public double Precocompra { get => precocompra; set => precocompra = value; }
        public int Estoque { get => estoque; set => estoque = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public string Fornecedor { get => fornecedor; set => fornecedor = value; }

        public Produtos(string descricao, int codbarras, double precovenda, double precocompra, int estoque, string categoria, string fornecedor)
        {
            // todo o resto não esta constando ser obrigatorio ser testado 
            if (string.IsNullOrEmpty(descricao)) throw new ArgumentNullException("descrição não pode ser vazia");
            if (codbarras < 10000) throw new ArgumentException("codigo invalido");
            if (precovenda < 1) throw new ArgumentException("favor verificar se o preço de venda esta correto");
            if (precocompra < 1) throw new ArgumentException("favor verificar se o preço de compra esta correto");
            this.descricao = descricao;
            this.codbarras = codbarras;
            this.precovenda = precovenda;
            this.precocompra = precocompra;
            this.estoque = estoque;
            this.categoria = categoria;
            this.fornecedor = fornecedor;
        }
    }
}
