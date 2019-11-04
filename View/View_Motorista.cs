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
    public partial class View_Motorista : Form
    {
        private Motorista motoristaEncontrado;
        public View_Motorista()
        {
            InitializeComponent();
        }

        public View_Motorista(Motorista Motorista)
        {
            InitializeComponent();

            buttonEnviar.Visible = false;
            buttonAlterar.Visible = buttonExcluir.Visible = true;

            ExibirDados(Motorista);
        }

        private void ExibirDados(Motorista Motorista)
        {
            motoristaEncontrado = Motorista;

            if (Motorista != null)
            {
                textBoxNome.Text = Motorista.Nome;
                textBoxCPF.Text = Motorista.CPF;
                textBoxCNH.Text = Motorista.CNH;
                textBoxCatCNH.Text = Motorista.CategoriaCNH;
                textBoxValidadeCNH.Text = Motorista.ValidadeCNH.ToShortDateString();
            }
        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            if (ValidarDados() == false)
                return;

            textBoxCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            textBoxCNH.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            Ctr_Motorista ctr_Motorista = new Ctr_Motorista();
            Motorista Motorista = new Motorista();
            Motorista.Nome = textBoxNome.Text;
            Motorista.CPF = textBoxCPF.Text;
            Motorista.CNH = textBoxCNH.Text;
            Motorista.CategoriaCNH = textBoxCatCNH.Text;
            Motorista.ValidadeCNH = DateTime.Parse(textBoxValidadeCNH.Text);

            textBoxCPF.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            textBoxCNH.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

            if (ctr_Motorista.Adicionar(Motorista))
            {
                LimparForm();
            }
            else
            {
                MessageBox.Show("Não foi possível se comunicar com o banco de dados. Pode haver algo errado com sua conexão com a rede ou os dados fornecidos não foram aceitos.", "Não foi possível realizar a operação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparForm()
        {
            motoristaEncontrado = null;
            textBoxNome.Text = "";
            textBoxCPF.Text = "";
            textBoxCNH.Text = "";
            textBoxCatCNH.Text = "";
            textBoxValidadeCNH.Text = "";
        }


        private bool ValidarDados()
        {
            string message = string.Empty;
            List<bool> testes = new List<bool>();

            textBoxCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            textBoxCNH.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            textBoxValidadeCNH.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (string.IsNullOrWhiteSpace(textBoxNome.Text))
            {
                message += "Campo nome está vazio.\n";
                testes.Add(false);
            }

            if (string.IsNullOrWhiteSpace(textBoxCPF.Text))
            {
                message += "Campo CPF está vazio.\n";
                testes.Add(false);
            }

            if (string.IsNullOrWhiteSpace(textBoxCNH.Text))
            {
                message += "Campo CNH está vazio.\n";
                testes.Add(false);
            }

            if (string.IsNullOrWhiteSpace(textBoxCatCNH.Text))
            {
                message += "Campo categoria de CNH está vazio.\n";
                testes.Add(false);
            }

            if (string.IsNullOrWhiteSpace(textBoxValidadeCNH.Text))
            {
                message += "Campo validade de CNH está vazio.\n";
                testes.Add(false);
            }

            textBoxCPF.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            textBoxCNH.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            textBoxValidadeCNH.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

            if (testes.Contains(false))
            {
                MessageBox.Show(message, "Dados inválidos");
                return false;
            }
            else
                return true;
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            if (ValidarDados() == false)
                return;

            textBoxCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            textBoxCNH.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            Ctr_Motorista Ctr_Motorista = new Ctr_Motorista();
            Motorista Motorista = new Motorista();
            Motorista.ID = motoristaEncontrado.ID;
            Motorista.Nome = textBoxNome.Text;
            Motorista.CPF = textBoxCPF.Text;
            Motorista.CNH = textBoxCNH.Text;
            Motorista.CategoriaCNH = textBoxCatCNH.Text;
            Motorista.ValidadeCNH = DateTime.Parse(textBoxValidadeCNH.Text);

            textBoxCPF.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            textBoxCNH.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

            if (Ctr_Motorista.Alterar(Motorista))
            {
                LimparForm();
                MessageBox.Show("Motorista alterado com sucesso!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Não foi possível se comunicar com o banco de dados. Pode haver algo errado com sua conexão com a rede ou os dados fornecidos não foram aceitos.", "Não foi possível realizar a operação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            Ctr_Motorista Ctr_Motorista = new Ctr_Motorista();

            if (Ctr_Motorista.Excluir(motoristaEncontrado))
            {
                LimparForm();
                MessageBox.Show("Motorista excluído com sucesso!");
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
    }
}
