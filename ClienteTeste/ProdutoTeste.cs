using Dominio;
using ExpectedObjects;
using System.Globalization;

namespace Teste
{
    public class ProdutoTeste
    {
        [Fact]
        public void CriarObjetoProduto()
        {
            var pro = ProdutoBuilder.Novo().GerarDados().Criar();
            var produtoEsperado = new
            {
                pro.Descricao,
                pro.Codbarras,
                pro.Precovenda,
                pro.Precocompra,
                pro.Estoque,
                pro.Categoria,
                pro.Fornecedor
            };
            produtoEsperado.ToExpectedObject().ShouldMatch(pro);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ProdutoDescricaoInvalida(string des)
        {
            Assert.Throws<ArgumentNullException>(
                () =>
            ProdutoBuilder.Novo().GerarDados().ComDescricao(des).Criar()
            );
        }
        [Theory]
        [InlineData(null)]
        [InlineData(-1)]
        [InlineData(0)]
        public void ProdutoCodigoInvalido(int codb)
        {
            Assert.Throws<ArgumentException>(
                () =>
            ProdutoBuilder.Novo().GerarDados().ComCodBarras(codb).Criar()
            );
        }
        [Theory]
        [InlineData(null)]
        [InlineData(-1)]
        [InlineData(0)]
        public void ProdutoPrecoVendaInvalido(int prev)
        {
            Assert.Throws<ArgumentException>(
                () =>
            ProdutoBuilder.Novo().GerarDados().ComPrecoVenda(prev).Criar()
            );
        }
        [Theory]
        [InlineData(null)]
        [InlineData(-1)]
        [InlineData(0)]
        public void ProdutoPrecoCompraInvalido(int prec)
        {
            Assert.Throws<ArgumentException>(
                () =>
            ProdutoBuilder.Novo().GerarDados().ComPrecoCompra(prec).Criar()
            );
        }

    }

}
