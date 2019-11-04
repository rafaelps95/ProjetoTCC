using ProjetoTCC.Control;
using ProjetoTCC.Model;
using ProjetoTCC.View.Consultas;
using ProjetoTCC.View.Pickers;
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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();

            this.Text = Sistema.NomedoSistema;
            label1.Text = label1.Text.Replace("@USER", Ctr_Usuario.UsuarioLogado.Username);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            View_Cliente View_Cliente = new View_Cliente();
            View_Cliente.ShowDialog();
        }

        private void menuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            View_Local View_Local = new View_Local();
            View_Local.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            View_Motorista View_Motorista = new View_Motorista();
            View_Motorista.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            View_Veiculo View_Veiculo = new View_Veiculo();
            View_Veiculo.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            View_Usuario View_Usuario = new View_Usuario();
            View_Usuario.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            View_Reserva View_Reserva = new View_Reserva();
            View_Reserva.ShowDialog();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            button1.ContextMenuStrip.Show(button1, e.Location);
        }

        private void Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Você realmente quer sair?", "Zezinho Transportes", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void ConsultarClientePorUsuario_Click(object sender, EventArgs e)
        {
            View_BuscarCliente vbc = new View_BuscarCliente(true);
            vbc.ShowDialog();
        }

        private void ConsultarClientePorDocumento_Click(object sender, EventArgs e)
        {
            View_BuscarCliente vbc = new View_BuscarCliente(false);
            vbc.ShowDialog();
        }

        private void Sobre_Click(object sender, EventArgs e)
        {
            Sobre Sobre = new Sobre();
            Sobre.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void criarNovoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View_Usuario view_Usuario = new View_Usuario();
            view_Usuario.ShowDialog();
        }

        private void redefinirSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View_BuscarUsuario view_BuscarUsuario = new View_BuscarUsuario();
            view_BuscarUsuario.ShowDialog();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReservaPicker reservaPicker = new ReservaPicker();
            reservaPicker.ShowDialog();
        }

        private void listarVeículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VeiculoPicker veiculoPicker = new VeiculoPicker(false);
            veiculoPicker.ShowDialog();
        }

        private void listarMotoristasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MotoristaPicker motoristaPicker = new MotoristaPicker(false);
            motoristaPicker.ShowDialog();
        }

        private void buscarLocalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocalPicker localPicker = new LocalPicker();
            localPicker.ShowDialog();
        }
    }
}
