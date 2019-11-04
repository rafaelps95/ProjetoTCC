using System;

namespace ProjetoTCC.Model
{
    public class Cliente
    {
        public int ID { get; set; }
        public string Nome {get;set;}
        public int Tipo { get; set; }
        public DateTime DataNasc { get; set; }
        public string CPF { get; set; }
        public string CNPJ { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public Usuario Usuario { get; set; }

        public Cliente()
        {
            Usuario = new Usuario();
            this.Nome = "";
            this.Tipo = 0;
            this.CPF = "";
            this.CNPJ = "";
            this.Email = "";
            this.Telefone = "";
        }
    }
}
