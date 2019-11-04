using ProjetoTCC.Control;
using ProjetoTCC.Model;
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
    public partial class View_Reserva : Form
    {
        private Reserva reserva { get; set; }
        private bool Alterar;

        public View_Reserva()
        {
            InitializeComponent();

            Alterar = false;
            reserva = new Reserva();
            reserva.Usuario = Ctr_Usuario.UsuarioLogado;
            //reserva.Veiculo = new Veiculo() { ValorDia = 825.12 };
            Ctr_Veiculo.DefinirVeiculo(new Veiculo());
            Ctr_Local.DefinirLocal(new Local(), Local.Tipo.Destino);
            Ctr_Local.DefinirLocal(new Local(), Local.Tipo.Partida);

            dateTimePartida.MinDate = dateTimeRetorno.MinDate = DateTime.Now;
            reserva.DataHoraInicial = reserva.DataHoraFinal = DateTime.Now;
            this.dateTimePartida.ValueChanged += new System.EventHandler(this.dateTimePartida_ValueChanged);
            this.dateTimeRetorno.ValueChanged += new System.EventHandler(this.dateTimeRetorno_ValueChanged);
        }

        public View_Reserva(Reserva Reserva)
        {
            InitializeComponent();

            Alterar = true;
            ExibirDados(Reserva);
            this.dateTimePartida.ValueChanged += new System.EventHandler(this.dateTimePartida_ValueChanged);
            this.dateTimeRetorno.ValueChanged += new System.EventHandler(this.dateTimeRetorno_ValueChanged);
        }

        private void ExibirDados(Reserva Reserva)
        {
            reserva = Reserva;
            reserva.Usuario = Ctr_Usuario.UsuarioLogado;

            if (Reserva.DataHoraInicial < DateTime.Now)
            {
                MessageBox.Show("Não é possível alterar uma reserva que já ocorreu ou está em andamento", "Não é possível alterar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = false;
            }
            else
            {
                dateTimePartida.MinDate = dateTimeRetorno.MinDate = DateTime.Now;
            }

            dateTimePartida.Value = reserva.DataHoraInicial;
            dateTimeRetorno.Value = reserva.DataHoraFinal;

            SetCliente(reserva.Cliente);
            SetLocalDestino(reserva.LocalDestino);
            SetLocalPartida(reserva.LocalPartida);
            SetVeiculo(reserva.Veiculo);
            SetMotorista(reserva.Motorista);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SetVeiculo(Ctr_Veiculo.PedirVeiculo());
        }

        public void SetMotorista(Motorista Motorista)
        {
            if (Motorista == null)
                return;

            reserva.Motorista = Motorista;
            textBoxMotorista.Text = Motorista.Nome;
        }

        public void SetVeiculo(Veiculo Veiculo)
        {
            if (Veiculo == null)
                return;

            reserva.Veiculo = Veiculo;
            textBoxVeiculo.Text = String.Format("{0} {1}, {2}, {3}", Veiculo.Marca, Veiculo.Modelo, Veiculo.Ano.ToString(), "R$" + Veiculo.ValorDia.ToString("F"));

            AtualizarValor();
        }

        public void SetCliente(Cliente Cliente)
        {
            if (Cliente == null)
                return;

            if (Cliente.Tipo == 0)
                textBoxCPFCNPJ.Text = Cliente.CPF;
            else
                textBoxCPFCNPJ.Text = Cliente.CNPJ;

            reserva.Cliente = Cliente;
            label7.Text = Cliente.Nome;
        }

        public void SetLocalPartida(Local Local)
        {
            if (Local == null)
                return;

            reserva.LocalPartida = Local;
            textBoxSaida.Text = String.Format("{0} - {1}, {2}, {3}", Local.Nome, Local.Bairro, Local.Cidade, Local.Estado);
        }

        public void SetLocalDestino(Local Local)
        {
            if (Local == null)
                return;

            reserva.LocalDestino = Local;
            textBoxDestino.Text = String.Format("{0} - {1}, {2}, {3}", Local.Nome, Local.Bairro, Local.Cidade, Local.Estado);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SetLocalDestino(Ctr_Local.PedirLocal(Local.Tipo.Destino));

            //LocalPicker localPicker = new LocalPicker("D");
            //localPicker.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetLocalPartida(Ctr_Local.PedirLocal(Local.Tipo.Partida));

            //LocalPicker localPicker = new LocalPicker("P");
            //localPicker.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ctr_Cliente Ctr_Cliente = new Ctr_Cliente();
            Cliente Cliente = new Cliente();

            bool isCPF;
            if (textBoxCPFCNPJ.Text.Length == 14)
            {
                Cliente.CNPJ = textBoxCPFCNPJ.Text;
                Cliente.CPF = "-";
                isCPF = false;
                //PESQUISAR POR CNPJ!
            }
            else if (textBoxCPFCNPJ.Text.Length == 11)
            {
                Cliente.CPF = textBoxCPFCNPJ.Text;
                Cliente.CNPJ = "-";
                isCPF = true;
                //PESQUISAR POR CPF!
            }
            else
            {
                isCPF = false;
                MessageBox.Show("Insira um CPF ou CNPJ válido. Somente números são permitidos neste campo.", "Somente números são permitidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Cliente cli = Ctr_Cliente.Buscar(Cliente);

            if (cli == null)
            {
                DialogResult result = MessageBox.Show("Gostaria de cadastrar o cliente agora?", "Cliente não cadastrado", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    View_Cliente View_Cliente = new View_Cliente(textBoxCPFCNPJ.Text, isCPF);
                    View_Cliente.ShowDialog();
                }
            }
            else
            {
                SetCliente(cli);
            }
        }

        private void dateTimePartida_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                reserva.DataHoraInicial = dateTimePartida.Value;
                dateTimeRetorno.MinDate = dateTimePartida.Value;
            }
            catch
            {

            }

            AtualizarValor();
        }

        private void dateTimeRetorno_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                reserva.DataHoraFinal = dateTimeRetorno.Value;
                dateTimePartida.MaxDate = dateTimeRetorno.Value;
            }
            catch
            {

            }

            AtualizarValor();
        }

        private void AtualizarValor()
        {
            Ctr_Reserva ctr_Reserva = new Ctr_Reserva();
            reserva.Valor = ctr_Reserva.CalcularValor(reserva);
            labelValor.Text = "R$ " + reserva.Valor.ToString("F");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (ValidarDados() == false)
                return;
            else
                ConfirmarDados();
        }

        private void ConfirmarDados()
        {
            string message = string.Empty;

            message += String.Format("Cliente: {0}", reserva.Cliente.Nome);
            message += String.Format("\nPartida: {0} - {1}, {2}/{3}\n{4}", reserva.LocalPartida.Nome,
                reserva.LocalPartida.Bairro,
                reserva.LocalPartida.Cidade,
                reserva.LocalPartida.Estado,
                reserva.DataHoraInicial.ToString("HH:mm dd/MM/yyyy"));
            message += String.Format("\nDestino: {0} - {1}, {2}/{3}\n{4}", reserva.LocalDestino.Nome,
                reserva.LocalDestino.Bairro,
                reserva.LocalDestino.Cidade,
                reserva.LocalDestino.Estado,
                reserva.DataHoraFinal.ToString("HH:mm dd/MM/yyyy"));
            message += String.Format("\nVeiculo: {0} {1}, {2}, {3} assentos", reserva.Veiculo.Marca, reserva.Veiculo.Modelo, reserva.Veiculo.Ano.ToString(), reserva.Veiculo.QtdAssentos.ToString());
            message += String.Format("\nValor: R${0}", reserva.Valor.ToString("F"));

            DialogResult result = MessageBox.Show(message, "Confirmação da reserva", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                //comprar!
                Pagamento pagamento = new Pagamento(reserva, this.Alterar);
                DialogResult res = pagamento.ShowDialog();
                if (res == DialogResult.Yes)
                    this.Close();
            }
            else
            {
                //revisar!
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SetMotorista(Ctr_Motorista.PedirMotorista());
        }

        private bool ValidarDados()
        {
            string message = string.Empty;
            List<bool> testes = new List<bool>();

            if (reserva.Cliente == null)
            {
                message += "Cliente não foi selecionado.\n";
                testes.Add(false);
            }

            if (reserva.LocalPartida == null)
            {
                message += "Partida não foi selecionada\n";
                testes.Add(false);
            }

            if (reserva.LocalDestino == null)
            {
                message += "Destino não foi selecionado\n";
                testes.Add(false);
            }

            if (reserva.Veiculo == null)
            {
                message += "Veiculo não foi selecionado\n";
                testes.Add(false);
            }

            if (reserva.Motorista == null)
            {
                message += "Motorista não foi selecionado\n";
                testes.Add(false);
            }

            if (testes.Contains(false))
            {
                MessageBox.Show(message, "Dados inválidos");
                return false;
            }
            else
                return true;
        }

    }
}
