namespace Dominio
{
    public class Fornecedor
    {
        // campos
        private string nomee;
        private string enderecoe;
        private string emaile;
        private string telefonee;
        private string termos;

        //propiedades
        public string Nomee { get => nomee; set => nomee = value; }
        public string Enderecoe { get => enderecoe; set => enderecoe = value; }
        public string Emaile { get => emaile; set => emaile = value; }
        public string Telefonee { get => telefonee; set => telefonee = value; }
        public string Termos { get => termos; set => termos = value; }


        public Fornecedor(string nomee, string enderecoe, string telefonee, string emaile, string termos)
        {
            if (string.IsNullOrEmpty(nomee)) throw new ArgumentException("Nome de empresa inválido");
            if (string.IsNullOrEmpty(enderecoe)) throw new ArgumentException("endereço de empresa inválido");
            if (string.IsNullOrEmpty(telefonee)) throw new ArgumentException("telefone de empresa inválido");
            // email nao é obrigatorio 
            // termos tambem não é obrigatorio 
            // se não ta escrito "obrigatorio tal coisa" ou "tal coisa tem que ser valida" não precisa ser testada, eu não recebo por trabalho a mais :)
            this.Nomee = nomee;
            this.Enderecoe = enderecoe;
            this.Emaile = emaile;
            this.Telefonee = telefonee;
            this.Termos = termos;

        }
    }
}
