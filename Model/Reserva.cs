using System;

namespace ProjetoTCC.Model
{
    public class Reserva
    {
        public int ID { get; set; }
        public Local LocalPartida { get; set; }

        public Local LocalDestino { get; set; }

        public Veiculo Veiculo { get; set; }

        public Motorista Motorista { get; set; }

        public Cliente Cliente { get; set; }

        public Usuario Usuario { get; set; }

        public DateTime DataHoraInicial { get; set; }

        public DateTime DataHoraFinal { get; set; }

        public double Valor { get; set; }

        public Reserva()
        {
            //this.LocalDestino = new Local();
            //this.LocalPartida = new Local();
            //this.Motorista = new Motorista();
            //this.Cliente = new Cliente();
            //this.Usuario = new Usuario();
            //this.Veiculo = new Veiculo();
        }
    }
}
