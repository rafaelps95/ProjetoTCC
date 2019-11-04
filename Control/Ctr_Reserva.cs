using ProjetoTCC.Dao;
using ProjetoTCC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTCC.Control
{
    class Ctr_Reserva
    {
        Dao_Reserva dao_Reserva;

        public bool Adicionar(Reserva Reserva)
        {
            return dao_Reserva.Create(Reserva);
        }

        public Reserva Buscar(Reserva Reserva)
        {
            return dao_Reserva.Read(Reserva);
        }

        public List<Reserva> BuscarReservas()
        {
            return dao_Reserva.GetReservas();
        }

        public bool Alterar(Reserva Reserva)
        {
            return dao_Reserva.Update(Reserva);
        }

        public double CalcularValor(Reserva Reserva)
        {
            if (Reserva.DataHoraInicial == null || Reserva.DataHoraFinal == null || Reserva.Veiculo == null)
                return 0.00;

            int dias = 1;

            try
            {
                dias += (Reserva.DataHoraFinal.Subtract(Reserva.DataHoraInicial).Days);
            }
            catch
            {

            }
            finally
            {
                Reserva.Valor = dias * Reserva.Veiculo.ValorDia;
            }

            return Reserva.Valor;
        }

        public bool Excluir(Reserva Reserva)
        {
            return dao_Reserva.Delete(Reserva);
        }

        public Ctr_Reserva()
        {
            dao_Reserva = new Dao_Reserva();
        }
    }
}
