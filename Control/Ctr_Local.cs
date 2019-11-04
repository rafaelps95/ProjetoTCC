using ProjetoTCC.Dao;
using ProjetoTCC.Model;
using ProjetoTCC.View.Pickers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTCC.Control
{
    class Ctr_Local
    {
        Dao_Local dao_Local;

        public bool Adicionar(Local Local)
        {
            return dao_Local.Create(Local);
        }

        public Local Buscar(Local Local)
        {
            return dao_Local.Read(Local);
        }

        public List<Local> BuscarLocais()
        {
            return dao_Local.GetLocais();
        }

        public bool Alterar(Local Local)
        {
            return dao_Local.Update(Local);
        }

        public bool Excluir(Local Local)
        {
            return dao_Local.Delete(Local);
        }

        public static Local PedirLocal(Local.Tipo tipo)
        {
            LocalPicker vp = new LocalPicker(tipo);
            vp.ShowDialog();

            if (tipo == Local.Tipo.Destino)
                return Destino;
            else
                return Partida;
        }

        public static void DefinirLocal(Local local, Local.Tipo tipo)
        {
            if (tipo == Local.Tipo.Destino)
                Destino = local;
            else
                Partida = local;
        }

        private static Local partida;

        private static Local Partida
        {
            get
            {
                return partida;
            }
            set
            {
                partida = value;
            }
        }

        private static Local destino;

        private static Local Destino
        {
            get
            {
                if (destino == null)
                    destino = new Local();

                return destino;
            }
            set
            {
                destino = value;
            }
        }

        public Ctr_Local()
        {
            dao_Local = new Dao_Local();
        }
    }
}
