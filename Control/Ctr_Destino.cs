using SistemaPim4.Dao;
using SistemaPim4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPim4.Control
{
    class Ctr_Destino
    {
        Dao_Destino dao_Destino;

        public bool Adicionar(Destino Destino)
        {
            return dao_Destino.Create(Destino);
        }

        public Destino Buscar(Destino Destino)
        {
            return dao_Destino.Read(Destino);
        }

        public bool Alterar(Destino Destino)
        {
            return dao_Destino.Update(Destino);
        }

        public bool Excluir(Destino Destino)
        {
            return dao_Destino.Delete(Destino);
        }

        public Ctr_Destino()
        {
            dao_Destino = new Dao_Destino(@"F:\PIM 4\SistemaPim4\SistemaPim4\BD\Banco.xls");
        }
    }
}
