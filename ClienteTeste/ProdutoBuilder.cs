using Dominio;
using Bogus;
using System.Data;

namespace Teste
{
    public class ProdutoBuilder
    {
        private string descricao = "leite";
        private int codbarras = 10000;
        private double precovenda = 23;
        private double precocompra = 12;
        private int estoque = 0;
        private string categoria = "laticinio";
        private string fornecedor = "bob leitada";

        public static ProdutoBuilder Novo()
        {
            return new ProdutoBuilder();
        }
        public Produtos Criar()
        {
            return new Produtos(
                descricao,
                codbarras,
                precovenda,
                precocompra,
                estoque,
                categoria,
                fornecedor
                );
        }

        public ProdutoBuilder GerarDados()
        {
            Faker faker = new Faker();

            descricao = faker.Random.String(length: 20);
            codbarras = faker.Random.Int(10000, 99999);
            precovenda = faker.Random.Double(1, 100);
            precocompra = faker.Random.Double(1, 50);
            estoque = faker.Random.Int(0, 100);
            categoria = faker.Random.String(length: 20);
            fornecedor = faker.Person.Company.Name;

            return this;
        }

        public ProdutoBuilder ComDescricao(string des)
        {
            this.descricao = des;
            return this;
        }
        public ProdutoBuilder ComCodBarras(int codb)  
        {   
            this.codbarras = codb;
            return this;
        }
        public ProdutoBuilder ComPrecoVenda(double prev)
        {
            this.precocompra = prev;
            return this;
        }
        public ProdutoBuilder ComPrecoCompra(double prec)
        {
            this.precocompra = prec;
            return this;
        }
        public ProdutoBuilder ComEstoque(int est)
        {
            this.estoque = est;
            return this;
        }
        public ProdutoBuilder ComCategoria(string cat)
        {
            this.categoria = cat;
            return this;
        }
        public ProdutoBuilder ComFornecedor(string forn)
        {
            this.fornecedor = forn;
            return this;
        }

    }
}