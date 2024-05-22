using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Bogus;

namespace Teste
{
    public class FornecedorBuilder
    {
        private string nomee = "bobs construtor";
        private string enderecoe = "rua bobs";
        private string telefonee = "987654321";
        private string emaile = "bobs@hot.com.br";
        private string termos = "venderas sua alma para programção";

        public static FornecedorBuilder Novo()
        {
            return new FornecedorBuilder();
        }

        public Fornecedor Criar()
        {
            return new Fornecedor
            (
                nomee,
                enderecoe,
                telefonee,
                emaile,
                termos
            );
        }
        public FornecedorBuilder GerarDados()
        {
            Faker faker = new Faker();

            nomee = faker.Person.FullName;
            enderecoe = faker.Address.FullAddress();
            telefonee = faker.Person.Phone;
            emaile = faker.Person.Email;
            termos = "aaaaa";

            return this;

        }
        public FornecedorBuilder ComNomee(string nome)
        {
            this.nomee = nome;
            return this;
        }

        public FornecedorBuilder ComEnderecoe(string ende)
        {
            this.enderecoe = ende;
            return this;
        }

        public FornecedorBuilder ComTelefonee(string tele)
        {
            this.telefonee = tele;
            return this;
        }

        public FornecedorBuilder ComTermos(string ter)
        {
            this.termos = ter;
            return this;
        }

        public FornecedorBuilder ComEmaile(string emaile)
        {
            this.emaile = emaile;
            return this;
        }
    }
}
