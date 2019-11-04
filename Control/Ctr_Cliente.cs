using ProjetoTCC.Dao;
using ProjetoTCC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTCC.Control
{
    class Ctr_Cliente
    {
        Dao_Cliente dao_Cliente;

        public bool Adicionar(Cliente Cliente)
        {
            return dao_Cliente.Create(Cliente);
        }

        public Cliente Buscar(Cliente Cliente)
        {
            return dao_Cliente.Read(Cliente);
        }

        public bool Alterar(Cliente Cliente)
        {
            return dao_Cliente.Update(Cliente);
        }

        public bool Excluir(Cliente Cliente)
        {
            return dao_Cliente.Delete(Cliente);
        }

        public static Int32 GetAge(DateTime dateOfBirth)
        {
            var today = DateTime.Today;

            var a = (today.Year * 100 + today.Month) * 100 + today.Day;
            var b = (dateOfBirth.Year * 100 + dateOfBirth.Month) * 100 + dateOfBirth.Day;

            return (a - b) / 10000;
        }

        public Ctr_Cliente()
        {
            dao_Cliente = new Dao_Cliente();
        }
    }
}
