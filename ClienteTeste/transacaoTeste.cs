using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using ExpectedObjects;

namespace Teste
{
    public class TransacaoTeste
    {
        [Fact]
        public void CriarObjetotransacaos()
        {
            var tra = TransacaoBuilder.Novo().GerarDados().Criars();
            var transacaoEsperado = new
            {
                Codigo = tra.Codigo,
                Quantidade = tra.Quantidade,
                Valor = tra.Valor,
                Data = tra.Data,
                Cliente = tra.Cliente,
                Motivo = tra.Motivo,
    };

            transacaoEsperado.ToExpectedObject().ShouldMatch(tra);

        }
        [Fact]
        public void CriarObjetotransacaoe()
        {
            var tra = TransacaoBuilder.Novo().GerarDados().Criare();
            var transacaoEsperado = new
            {
                Codigo = tra.Codigo,
                Quantidade = tra.Quantidade,
                Valor = tra.Valor,
                Data = tra.Data,
                Forncedor = tra.Forncedor,
                Motivo = tra.Motivo,
            };

            transacaoEsperado.ToExpectedObject().ShouldMatch(tra);

        }
        [Theory]
        [InlineData(null)]
        [InlineData(-1)]
        [InlineData(0)]
        public void TransacaosCodigoInvalidos(int cod)
        {
            Assert.Throws<ArgumentException>(
                () =>
            TransacaoBuilder.Novo().GerarDados().ComCodigo(cod).Criars()
            );
        }

        [Theory]
        [InlineData(null)]
        [InlineData(-1)]
        [InlineData(0)]
        public void TransacaoeCodigoInvalidoe(int cod)
        {
            Assert.Throws<ArgumentException>(
                () =>
            TransacaoBuilder.Novo().GerarDados().ComCodigo(cod).Criare()
            );
        }
        
    }
}
