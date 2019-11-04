using System;

namespace ProjetoTCC.Model
{
    public class Motorista
    {
        public int ID { get; set; }

        public string Nome { get; set; }

        public string CPF { get; set; }

        public string CNH { get; set; }

        public string CategoriaCNH { get; set; }

        public DateTime ValidadeCNH { get; set; }

        public Motorista()
        {

        }
    }
}
