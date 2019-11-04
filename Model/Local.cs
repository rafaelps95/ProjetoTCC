namespace ProjetoTCC.Model
{
    public class Local
    {
        public enum Tipo
        {
            Partida,
            Destino
        }

        public int ID { get; set; }

        //public string Rua { get; set; }

        public string Nome { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        //public string CEP { get; set; }

        //public int Numero { get; set; }


        public Local()
        {

        }
    }
}
