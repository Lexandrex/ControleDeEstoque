using ExpectedObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Bogus.DataSets;

namespace Teste
{
    public class FornecedorTeste
    {
        [Fact]
        public void CriarObjetoFornecedor()
        {
            var forn = FornecedorBuilder.Novo().GerarDados().Criar();
            var fornecedorEsperado = new
            {
                
                Nomee = forn.Nomee,
                Enderecoe = forn.Enderecoe,
                Emaile = forn.Emaile,
                Telefonee = forn.Telefonee,
                Termos = forn.Termos
            };

            fornecedorEsperado.ToExpectedObject().ShouldMatch(forn);

        }


        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void FornecedorNomeInvalido(string nome)
        {
            Assert.Throws<ArgumentException>(
                () =>
            FornecedorBuilder.Novo().GerarDados().ComNomee(nome).Criar()
            );
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void FornecedorEnderecoInvalido(string ende)
        {
            Assert.Throws<ArgumentException>(
                () =>
            FornecedorBuilder.Novo().GerarDados().ComEnderecoe(ende).Criar()
            );
        }


        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void FornecedorTelefoneInvalido(string tele)
        {
            Assert.Throws<ArgumentException>(
                () =>
            FornecedorBuilder.Novo().GerarDados().ComTelefonee(tele).Criar()
            );
        }

    }
}
