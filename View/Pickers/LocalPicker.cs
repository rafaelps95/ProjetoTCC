using ProjetoTCC.Model;
using ProjetoTCC.Control;
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
    public partial class LocalPicker : Form
    {
        private bool SelecionarParaReserva;
        private Local.Tipo Tipo;

        private string Modo { get; set; }
        public LocalPicker()
        {
            InitializeComponent();

            this.SelecionarParaReserva = false;
            label1.Text = "Selecione o local";
            BuscarLocais();
        }

        public LocalPicker(Local.Tipo tipo)
        {
            InitializeComponent();

            this.SelecionarParaReserva = true;
            this.Tipo = tipo;

            if (this.Tipo == Local.Tipo.Destino)
                label1.Text = "Selecione o destino";
            else
                label1.Text = "Selecione a partida";

            BuscarLocais();
        }

        private void BuscarLocais()
        {
            Ctr_Local Ctr_Local = new Ctr_Local();
            List<Local> list = Ctr_Local.BuscarLocais();


            foreach (Local l in list)
            {
                ListViewItem lvi = new ListViewItem(l.ID.ToString());
                lvi.SubItems.Add(Convert.ToString(l.Nome));
                lvi.SubItems.Add(l.Bairro);
                lvi.SubItems.Add(l.Cidade);
                lvi.SubItems.Add(l.Estado);
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
            Local Local = new Local();
            Local.ID = Convert.ToInt16(listView1.SelectedItems[0].SubItems[0].Text);
            Local.Nome = listView1.SelectedItems[0].SubItems[1].Text;
            Local.Bairro = listView1.SelectedItems[0].SubItems[2].Text;
            Local.Cidade = listView1.SelectedItems[0].SubItems[3].Text;
            Local.Estado = listView1.SelectedItems[0].SubItems[4].Text;

            if (this.SelecionarParaReserva)
                Ctr_Local.DefinirLocal(Local, Tipo);
            else
            {
                View_Local view_Local = new View_Local(Local);
                view_Local.ShowDialog();
            }

            this.Close();
        }
    }
}
