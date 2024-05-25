using Dominio;
using Bogus.Extensions.Brazil;
using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Bogus.DataSets;


namespace Teste
{
    public class TransacaoBuilder
    {
        private int codigo = 1;
        private int quantidade = 1;
        private double valor = 1;
        private string data = "12/12/2012";
        private string fornecedor = "bobs hork";
        private string cliente = "paulo";
        private string fatura = "32";
        private string motivo = "entrada/saida";

        public static TransacaoBuilder Novo()
        {
            return new TransacaoBuilder();
        }

        public Transacaoe Criare()
        {
            return new Transacaoe(
                codigo,
                quantidade,
                valor,
                data,
                fornecedor,
                fatura,
                motivo);
        }

        public Transacaos Criars()
        {
            return new Transacaos(
                codigo,
                quantidade,
                valor,
                data,
                cliente,
                motivo);
        }
        public TransacaoBuilder GerarDados()
        {
            Faker faker = new Faker();

            codigo = faker.Random.Int(1, 1000);
            quantidade = faker.Random.Int(1, 1000);
            valor = faker.Random.Double(1, 100);
            data = faker.Date.ToString();
            fornecedor = faker.Person.Company.Name;
            cliente = faker.Person.FullName;
            fatura = faker.Random.Int().ToString();
            motivo = faker.Random.String(length: 15);

            return this;
        }
        public TransacaoBuilder ComCodigo(int cod)
        {
            this.codigo = cod;
            return this;
        }
        public TransacaoBuilder ComQuantidade(int qtd)
        {
            this.quantidade = qtd;
            return this;
        }
        public TransacaoBuilder ComValor(int val)
        {
            this.valor = val;
            return this;
        }
        public TransacaoBuilder ComData(string dat)
        {
            this.data = dat;
            return this;
        }
        public TransacaoBuilder ComFornecedor(string forn)
        {
            this.fornecedor = forn;
            return this;
        }
        public TransacaoBuilder ComCliente(string cli)
        {
            this.cliente = cli;
            return this;
        }
        public TransacaoBuilder ComFatura(string fat)
        {
            this.fatura = fat;
            return this;
        }
        public TransacaoBuilder ComMotivo(string mot) 
        {
            this.motivo = mot; 
            return this;
        }
    }

}
