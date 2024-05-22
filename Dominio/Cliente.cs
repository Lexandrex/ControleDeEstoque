namespace Dominio
{
    public class Cliente
    {
        // campos
        private int codigo;
        private string nome;
        private string endereco;
        private string email;
        private string telefone;

        //propiedades
        public string Nome { get => nome; set => nome = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Email { get => email; set => email = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public int Codigo { get => codigo; set => codigo = value; }

        public Cliente(int codigo, string nome, string endereco, string email, string telefone)
        {
            if (string.IsNullOrEmpty(nome)) throw new ArgumentException("Nome inválido");
            if (codigo < 1) throw new ArgumentException("Código inválido");
            if (!EmailValido(email)) throw new ArgumentException("Email inválido");
            if (string.IsNullOrEmpty(telefone)) throw new ArgumentException("telefone inválido");
            if (string.IsNullOrEmpty(endereco)) throw new ArgumentException("endereço inválido");
            this.Codigo = codigo;
            this.Nome = nome;
            this.Endereco = endereco;
            this.Email = email;
            this.Telefone = telefone;

        }
        public bool EmailValido(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

    }
}
