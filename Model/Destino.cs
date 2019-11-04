using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPim4.Model
{
    class Destino
    {
        public string Rua { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public DateTime DataHora { get; set; }

        public Destino()
        {

        }
    }
}
