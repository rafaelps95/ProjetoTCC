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
    public partial class MotoristaPicker : Form
    {
        private bool SelecionarParaReserva;

        public MotoristaPicker(bool selecionarParaReserva)
        {
            InitializeComponent();

            this.SelecionarParaReserva = selecionarParaReserva;
            BuscarMotoristas();
        }

        private void BuscarMotoristas()
        {
            Ctr_Motorista Ctr_Motorista = new Ctr_Motorista();
            List<Motorista> list = Ctr_Motorista.BuscarMotoristas();


            foreach (Motorista m in list)
            {
                ListViewItem lvi = new ListViewItem(m.ID.ToString());
                lvi.SubItems.Add(m.Nome);
                lvi.SubItems.Add(m.CPF);
                lvi.SubItems.Add(Convert.ToString(m.CNH));
                lvi.SubItems.Add(Convert.ToString(m.CategoriaCNH));
                lvi.SubItems.Add(Convert.ToString(m.ValidadeCNH.ToShortDateString()));
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
            Motorista Motorista = new Motorista();
            Motorista.ID = Convert.ToInt16(listView1.SelectedItems[0].SubItems[0].Text);
            Motorista.Nome = listView1.SelectedItems[0].SubItems[1].Text;
            Motorista.CPF = listView1.SelectedItems[0].SubItems[2].Text;
            Motorista.CNH = listView1.SelectedItems[0].SubItems[3].Text;
            Motorista.CategoriaCNH = listView1.SelectedItems[0].SubItems[4].Text;
            Motorista.ValidadeCNH = DateTime.Parse(listView1.SelectedItems[0].SubItems[5].Text);

            if (this.SelecionarParaReserva)
                Ctr_Motorista.DefinirMotorista(Motorista);
            else
            {
                View_Motorista view_Motorista = new View_Motorista(Motorista);
                view_Motorista.ShowDialog();
            }

            this.Close();
        }
    }
}
