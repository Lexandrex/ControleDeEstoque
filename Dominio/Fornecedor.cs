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


        public Fornecedor(string nomee, string enderecoe, string emaile, string telefonee, string termos)
        {
            if (string.IsNullOrEmpty(nomee)) throw new ArgumentException("Nome de empresa inválido");
            
            this.Nomee = nomee;
            this.Enderecoe = enderecoe;
            this.Emaile = emaile;
            this.Telefonee = telefonee;
            this.Termos = termos;

        }
    }
}
