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

namespace ProjetoTCC.View
{
    public partial class Pagamento : Form
    {
        private Timer Timer;
        private Reserva Reserva;
        private bool Alterar;

        public Pagamento(Reserva Reserva, bool alterar)
        {
            InitializeComponent();

            this.Reserva = Reserva;
            this.Alterar = alterar;
            LoadUI();
        }

        private void LoadUI()
        {
            Timer = new Timer();
            Timer.Interval = 3000;
            Timer.Tick += Timer_Tick;
            Timer.Start();
            labelValor.Text = "R$" + Reserva.Valor.ToString("F");

            if (this.Alterar)
            {
                label1.Text = "Processando diferença de valor...";
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Timer.Stop();

            Ctr_Reserva ctr_Reserva = new Ctr_Reserva();

            if (this.Alterar)
            {
                if (ctr_Reserva.Alterar(Reserva))
                {
                    this.DialogResult = DialogResult.Yes;
                    MessageBox.Show("Reserva alterada com sucesso!");
                    this.Close();
                }
                else
                {
                    this.DialogResult = DialogResult.No;
                    MessageBox.Show("Não foi possível se comunicar com o banco de dados. Pode haver algo errado com sua conexão com a rede ou os dados fornecidos não foram aceitos.", "Não foi possível realizar a operação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (ctr_Reserva.Adicionar(Reserva))
                {
                    this.DialogResult = DialogResult.Yes;
                    MessageBox.Show("Reserva agendada com sucesso!", "Pagamento confirmado!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    this.DialogResult = DialogResult.No;
                    MessageBox.Show("Não foi possível se comunicar com o banco de dados. Pode haver algo errado com sua conexão com a rede ou os dados fornecidos não foram aceitos.", "Não foi possível realizar a operação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            this.Close();
        }
    }
}
