using ProjetoTCC.Control;
using ProjetoTCC.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTCC.View.Pickers
{
    public partial class VeiculoPicker : Form
    {
        private bool SelecionarParaReserva;

        public VeiculoPicker(bool selecionarParaReserva)
        {
            InitializeComponent();

            this.SelecionarParaReserva = selecionarParaReserva;
            BuscarVeiculos();
        }

        private void BuscarVeiculos()
        {
            Ctr_Veiculo Ctr_Veiculo = new Ctr_Veiculo();
            List<Veiculo> list = Ctr_Veiculo.BuscarVeiculos();


            foreach (Veiculo v in list)
            {
                ListViewItem lvi = new ListViewItem(v.ID.ToString());
                lvi.SubItems.Add(v.Marca);
                lvi.SubItems.Add(v.Modelo);
                lvi.SubItems.Add(v.Ano.ToString());
                lvi.SubItems.Add(v.Placa);
                lvi.SubItems.Add(Convert.ToString(v.QtdAssentos));
                lvi.SubItems.Add(Convert.ToString(v.ValorDia));
                listView1.Items.Add(lvi);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                buttonSelecionar.Enabled = false;
            else
                buttonSelecionar.Enabled = true;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSelecionar_Click(object sender, EventArgs e)
        {
            Veiculo Veiculo = new Veiculo();
            Veiculo.ID = Convert.ToInt16(listView1.SelectedItems[0].SubItems[0].Text);
            Veiculo.Marca = listView1.SelectedItems[0].SubItems[1].Text;
            Veiculo.Modelo = listView1.SelectedItems[0].SubItems[2].Text;
            Veiculo.Ano = Convert.ToInt16(listView1.SelectedItems[0].SubItems[3].Text);
            Veiculo.Placa = listView1.SelectedItems[0].SubItems[4].Text;
            Veiculo.QtdAssentos = Convert.ToInt16(listView1.SelectedItems[0].SubItems[5].Text);
            Veiculo.ValorDia = Convert.ToDouble(listView1.SelectedItems[0].SubItems[6].Text);

            if (this.SelecionarParaReserva)
                Ctr_Veiculo.DefinirVeiculo(Veiculo);
            else
            {
                View_Veiculo view_Veiculo = new View_Veiculo(Veiculo);
                view_Veiculo.ShowDialog();
            }

            this.Close();
        }
    }
}
