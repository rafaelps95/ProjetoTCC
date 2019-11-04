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
    public partial class View_Local : Form
    {
        private Local localEncontrado;
        public View_Local()
        {
            InitializeComponent();
        }

        public View_Local(Local Local)
        {
            InitializeComponent();

            buttonEnviar.Visible = false;
            buttonAlterar.Visible = buttonExcluir.Visible = true;

            ExibirDados(Local);
        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            if (ValidarDados() == false)
                return;

            Ctr_Local Ctr_Local = new Ctr_Local();
            Local Local = new Local();

            Local.Nome = textBoxNome.Text;
            Local.Bairro = textBoxBairro.Text;
            Local.Cidade = textBoxCidade.Text;
            Local.Estado = textBoxEstado.Text;

            if (Ctr_Local.Adicionar(Local))
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

            Ctr_Local Ctr_Local = new Ctr_Local();
            Local Local = localEncontrado;

            Local.Nome = textBoxNome.Text;
            Local.Bairro = textBoxBairro.Text;
            Local.Cidade = textBoxCidade.Text;
            Local.Estado = textBoxEstado.Text;

            if (Ctr_Local.Alterar(Local))
            {
                LimparForm();
            }
            else
            {
                MessageBox.Show("Não foi possível se comunicar com o banco de dados. Pode haver algo errado com sua conexão com a rede ou os dados fornecidos não foram aceitos.", "Não foi possível realizar a operação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarDados()
        {
            string message = string.Empty;
            List<bool> testes = new List<bool>();

            if (string.IsNullOrWhiteSpace(textBoxBairro.Text))
            {
                message += "Campo bairro está vazio.\n";
                testes.Add(false);
            }


            if (string.IsNullOrWhiteSpace(textBoxCidade.Text))
            {
                message += "Campo cidade está vazio.\n";
                testes.Add(false);
            }

            if (string.IsNullOrWhiteSpace(textBoxEstado.Text))
            {
                message += "Campo estado está vazio.\n";
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

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            Ctr_Local Ctr_Local = new Ctr_Local();

            if (Ctr_Local.Excluir(localEncontrado))
            {
                LimparForm();
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

        private void LimparForm()
        {
            textBoxNome.Text = "";
            textBoxBairro.Text = "";
            textBoxCidade.Text = "";
            textBoxEstado.Text = "";
        }

        private void ExibirDados(Local Local)
        {
            localEncontrado = Local;

            if (Local != null)
            {
                textBoxNome.Text = Local.Nome;
                textBoxBairro.Text = Local.Bairro;
                textBoxCidade.Text = Local.Cidade;
                textBoxEstado.Text = Local.Estado;
            }
        }
    }
}
