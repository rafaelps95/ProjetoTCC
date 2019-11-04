using ProjetoTCC.Dao;
using ProjetoTCC.Model;
using ProjetoTCC.View.Pickers;
using System.Collections.Generic;

namespace ProjetoTCC.Control
{
    class Ctr_Veiculo
    {
        Dao_Veiculo dao_Veiculo;

        public bool Adicionar(Veiculo Veiculo)
        {
            return dao_Veiculo.Create(Veiculo);
        }

        public Veiculo Buscar(Veiculo Veiculo)
        {
            return dao_Veiculo.Read(Veiculo);
        }

        public List<Veiculo> BuscarVeiculos()
        {
            return dao_Veiculo.GetVeiculos();
        }

        public bool Alterar(Veiculo Veiculo)
        {
            return dao_Veiculo.Update(Veiculo);
        }

        public bool Excluir(Veiculo Veiculo)
        {
            return dao_Veiculo.Delete(Veiculo);
        }

        public static Veiculo PedirVeiculo()
        {
            VeiculoPicker vp = new VeiculoPicker(true);
            vp.ShowDialog();

            return Veiculo;
        }

        public static void DefinirVeiculo(Veiculo veiculo)
        {
            Veiculo = veiculo;
        }

        private static Veiculo veiculo;

        private static Veiculo Veiculo
        {
            get
            {
                return veiculo;
            }
            set
            {
                veiculo = value;
            }
        }

        public Ctr_Veiculo()
        {
            dao_Veiculo = new Dao_Veiculo();
        }
    }
}
