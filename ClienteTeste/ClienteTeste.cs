using Dominio;
using ExpectedObjects;

namespace Teste
{
    public class ClienteTeste
    {

        [Fact]
        public void CriarObjetoCliente()
        {
            var cli = ClienteBuilder.Novo().GerarDados().Criar();
            var clienteEsperado = new
            {
                Codigo = cli.Codigo,
                Nome = cli.Nome,
                Endereco = cli.Endereco,
                Email = cli.Email,
                Telefone = cli.Telefone
            };

            clienteEsperado.ToExpectedObject().ShouldMatch(cli);

        }

        [Theory]
        [InlineData(null)]
        [InlineData(-1)]
        [InlineData(0)]
        public void ClienteCodigoInvalido(int cod)
        {
            Assert.Throws<ArgumentException>(
                () =>
            ClienteBuilder.Novo().GerarDados().ComCodigo(cod).Criar()
            );
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ClienteNomeInvalido(string nome)
        {
            Assert.Throws<ArgumentException>(
                () =>
            ClienteBuilder.Novo().GerarDados().ComNome(nome).Criar()
            );
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ClienteEnderecoInvalido(string end)
        {
            Assert.Throws<ArgumentException>(
                () =>
            ClienteBuilder.Novo().GerarDados().ComEndereco(end).Criar()
            );
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ClienteTelefoneInvalido(string tel)
        {
            Assert.Throws<ArgumentException>(
                () =>
            ClienteBuilder.Novo().GerarDados().ComTelefone(tel).Criar()
            );
        }

        [Theory]
        [InlineData("ale")]
        [InlineData("ale@")]
        [InlineData("@hot.com.br")]
        public void ClienteEmailInvalido(string ema)
        {
            Assert.Throws<ArgumentException>(
                () =>
            ClienteBuilder.Novo().GerarDados().ComEmail(ema).Criar()
            );
        }

    }
}