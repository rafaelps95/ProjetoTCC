using ProjetoTCC.Dao;
using ProjetoTCC.Model;
using ProjetoTCC.View.Pickers;
using System.Collections.Generic;

namespace ProjetoTCC.Control
{
    class Ctr_Motorista
    {
        Dao_Motorista dao_Motorista;

        public bool Adicionar(Motorista Motorista)
        {
            return dao_Motorista.Create(Motorista);
        }

        public Motorista Buscar(Motorista Motorista)
        {
            return dao_Motorista.Read(Motorista);
        }

        public List<Motorista> BuscarMotoristas()
        {
            return dao_Motorista.GetMotoristas();
        }

        public bool Alterar(Motorista Motorista)
        {
            return dao_Motorista.Update(Motorista);
        }

        public bool Excluir(Motorista Motorista)
        {
            return dao_Motorista.Delete(Motorista);
        }

        public static Motorista PedirMotorista()
        {
            MotoristaPicker mp = new MotoristaPicker(true);
            mp.ShowDialog();

            return Motorista;            
        }

        public static void DefinirMotorista(Motorista motorista)
        {
            Motorista = motorista;
        }

        private static Motorista motorista;

        private static Motorista Motorista
        {
            get
            {
                return motorista;
            }
            set
            {
                motorista = value;
            }
        }


        public Ctr_Motorista()
        {
            dao_Motorista = new Dao_Motorista();
        }
    }
}
