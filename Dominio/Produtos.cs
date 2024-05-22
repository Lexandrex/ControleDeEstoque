namespace Dominio
{
    internal class Produtos
    {
        private string descricao;
        private string codbarras;
        private string precocompra;
        private string precovenda;
        private string qtd;

        public string Descricao { get => descricao; set => descricao = value; }
        public string Codbarras { get => codbarras; set => codbarras = value; }
        public string Precocompra { get => precocompra; set => precocompra = value; }
        public string Precovenda { get => precovenda; set => precovenda = value; }
        public string Qtd { get => qtd; set => qtd = value; }
    }
}
