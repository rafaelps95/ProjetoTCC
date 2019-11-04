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
    public partial class ReservaPicker : Form
    {
        public ReservaPicker()
        {
            InitializeComponent();

            BuscarReservas();
        }

        private void BuscarReservas()
        {
            Ctr_Reserva ctr_Reserva = new Ctr_Reserva();
            List<Reserva> list = ctr_Reserva.BuscarReservas();

            foreach (Reserva r in list)
            {
                ListViewItem lvi = new ListViewItem(r.ID.ToString());
                lvi.SubItems.Add(r.Cliente.Nome);
                lvi.SubItems.Add(r.DataHoraInicial.ToString());
                lvi.SubItems.Add(r.LocalDestino.Nome);
                lvi.SubItems.Add(r.Valor.ToString());
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
            Ctr_Reserva ctr_Reserva = new Ctr_Reserva();
            Reserva Reserva = new Reserva();
            Reserva.ID = Convert.ToInt16(listView1.SelectedItems[0].SubItems[0].Text);

            Reserva = ctr_Reserva.Buscar(Reserva);
            //Sistema.Instance.View_Reserva.SetVeiculo(Veiculo);

            View_Reserva view_Reserva = new View_Reserva(Reserva);
            view_Reserva.ShowDialog();
            this.Close();
        }
    }
}
