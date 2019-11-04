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
    public partial class View_Veiculo : Form
    {
        private Veiculo veiculoEncontrado;
        public View_Veiculo()
        {
            InitializeComponent();
        }

        public View_Veiculo(Veiculo Veiculo)
        {
            InitializeComponent();

            buttonEnviar.Visible = false;
            buttonAlterar.Visible = buttonExcluir.Visible = true;

            ExibirDados(Veiculo);
        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            if (ValidarDados() == false)
                return;

            Ctr_Veiculo Ctr_Veiculo = new Ctr_Veiculo();
            Veiculo Veiculo = new Veiculo();

            Veiculo.Placa = textBoxPlaca.Text;
            Veiculo.Marca = textBoxMarca.Text;
            Veiculo.Modelo = textBoxModelo.Text;
            Veiculo.Ano = Convert.ToInt16(textBoxAno.Text);
            Veiculo.QtdAssentos = Convert.ToInt16(textBoxQtdAssentos.Text);
            Veiculo.ValorDia = Convert.ToDouble(textBoxValor.Text);

            if (Ctr_Veiculo.Adicionar(Veiculo))
            {
                LimparForm();
            }
            else
            {
                MessageBox.Show("Não foi possível se comunicar com o banco de dados. Pode haver algo errado com sua conexão com a rede ou os dados fornecidos não foram aceitos.", "Não foi possível realizar a operação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            if (ValidarDados() == false)
                return;

            Ctr_Veiculo Ctr_Veiculo = new Ctr_Veiculo();
            Veiculo Veiculo = new Veiculo();

            Veiculo.ID = veiculoEncontrado.ID;
            Veiculo.Placa = textBoxPlaca.Text;
            Veiculo.Marca = textBoxMarca.Text;
            Veiculo.Modelo = textBoxModelo.Text;
            Veiculo.Ano = Convert.ToInt16(textBoxAno.Text);
            Veiculo.QtdAssentos = Convert.ToInt16(textBoxQtdAssentos.Text);
            Veiculo.ValorDia = Convert.ToDouble(textBoxValor.Text);

            if (Ctr_Veiculo.Alterar(Veiculo))
            {
                LimparForm();
                MessageBox.Show("Veículo alterado com sucesso!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Não foi possível se comunicar com o banco de dados. Pode haver algo errado com sua conexão com a rede ou os dados fornecidos não foram aceitos.", "Não foi possível realizar a operação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            Ctr_Veiculo Ctr_Veiculo = new Ctr_Veiculo();
            Veiculo Veiculo = veiculoEncontrado;

            if (Ctr_Veiculo.Excluir(Veiculo))
            {
                LimparForm();
                MessageBox.Show("Veículo excluído com sucesso!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Não foi possível se comunicar com o banco de dados. Pode haver algo errado com sua conexão com a rede ou os dados fornecidos não foram aceitos.", "Não foi possível realizar a operação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            LimparForm();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            Ctr_Veiculo Ctr_Veiculo = new Ctr_Veiculo();
            Veiculo Veiculo = new Veiculo();
            Veiculo.Placa = textBoxPlaca.Text;

            ExibirDados(Ctr_Veiculo.Buscar(Veiculo));
        }

        private bool ValidarDados()
        {
            string message = string.Empty;
            List<bool> testes = new List<bool>();

            textBoxPlaca.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (string.IsNullOrWhiteSpace(textBoxPlaca.Text))
            {
                message += "Campo placa está vazio.\n";
                testes.Add(false);
            }

            if (string.IsNullOrWhiteSpace(textBoxModelo.Text))
            {
                message += "Campo modelo está vazio.\n";
                testes.Add(false);
            }

            if (string.IsNullOrWhiteSpace(textBoxMarca.Text))
            {
                message += "Campo marca está vazio.\n";
                testes.Add(false);
            }

            if (string.IsNullOrWhiteSpace(textBoxAno.Text) || textBoxAno.Text.Length < 4)
            {
                message += "Campo ano está vazio ou em um formato incorreto.\n";
                testes.Add(false);
            }

            if (string.IsNullOrWhiteSpace(textBoxValor.Text))
            {
                message += "Campo valor está vazio.\n";
                testes.Add(false);
            }

            if (string.IsNullOrWhiteSpace(textBoxQtdAssentos.Text))
            {
                message += "Campo quantidade de assentos está vazio.\n";
                testes.Add(false);
            }
            //else if (string.IsNullOrWhiteSpace())

            textBoxPlaca.TextMaskFormat = MaskFormat.IncludeLiterals;

            if (testes.Contains(false))
            {
                MessageBox.Show(message, "Dados inválidos");
                return false;
            }
            else
                return true;
        }

        private void ExibirDados(Veiculo Veiculo)
        {
            veiculoEncontrado = Veiculo;

            if (Veiculo != null)
            {
                textBoxPlaca.Text = Veiculo.Placa;
                textBoxMarca.Text = Veiculo.Marca;
                textBoxModelo.Text = Veiculo.Modelo;
                textBoxAno.Text = Convert.ToString(Veiculo.Ano);
                textBoxQtdAssentos.Text = Convert.ToString(Veiculo.QtdAssentos);
                textBoxValor.Text = Convert.ToString(Veiculo.ValorDia);
            }
            else
            {
                LimparForm();
            }
        }

        private void LimparForm()
        {
            veiculoEncontrado = null;
            textBoxPlaca.Text = "";
            textBoxMarca.Text = "";
            textBoxModelo.Text = "";
            textBoxAno.Text = "";
            textBoxQtdAssentos.Text = "";
            textBoxValor.Text = "";
        }
    }
}
