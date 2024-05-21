using Dominio;
using Bogus.Extensions.Brazil;
using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    public class ClienteBuilder
    {
        //campos
        private int codigo = 1;
        private string nome = "Alexandre";
        private string endereco = "praia rosa";
        private string email = "alexandre@hotm.com.br";
        private string telefone = "123456789";

        public static ClienteBuilder Novo()
        {
            return new ClienteBuilder();
        }

        public Cliente Criar()
        {
            return new Cliente(
                codigo,
                nome,
                endereco,
                email,
                telefone);
        }

        public ClienteBuilder GerarDados()
        {
           Faker faker = new Faker();

            codigo = faker.Random.Int(1, 1000);
            nome = faker.Person.FullName;
            endereco = faker.Address.FullAddress();
            email = faker.Person.Email;
            telefone = faker.Person.Phone;

            return this;
        }
        public ClienteBuilder ComNome(string nom)
        {
            this.nome = nom;
            return this;
        }
        
        public ClienteBuilder ComEndereco(string end)
        {
            this.endereco = end;
            return this;
        }

        public ClienteBuilder ComEmail(string ema)
        {
            this.email = ema;
            return this;
        }

        public ClienteBuilder ComTelefone(string tel)
        {
            this.telefone = tel;
            return this;
        }
        public ClienteBuilder ComCodigo(int cod)
        {
            this.codigo = cod;
            return this;
        }
    }
}
