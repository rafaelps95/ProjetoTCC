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
    public partial class View_Usuario : Form
    {
        private Usuario usuarioEncontrado;

        public View_Usuario()
        {
            InitializeComponent();
        }

        public View_Usuario(Usuario Usuario)
        {
            InitializeComponent();
            ExibirDados(Usuario);
        }

        private void ExibirDados(Usuario Usuario)
        {
            this.usuarioEncontrado = Usuario;

            textBoxUsername.Text = usuarioEncontrado.Username;
            textBoxUsername.Enabled = false;
            comboBoxTipo.SelectedIndex = usuarioEncontrado.Tipo;
            comboBoxTipo.Enabled = false;
            textBoxDica.Text = usuarioEncontrado.DicaSenha;

            buttonAlterar.Visible = true;
            buttonEnviar.Visible = false;
        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            if (ValidarDados() == false)
                return;

            Ctr_Usuario Ctr_Usuario = new Ctr_Usuario();
            Usuario Usuario = new Usuario();
            Usuario.Username = textBoxUsername.Text;
            Usuario.Senha = textBoxSenha.Text;
            Usuario.Tipo = comboBoxTipo.SelectedIndex;
            Usuario.DicaSenha = textBoxDica.Text;

            if (Ctr_Usuario.Adicionar(Usuario))
            {
                LimparForm();
                this.Close();
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

            Ctr_Usuario Ctr_Usuario = new Ctr_Usuario();
            Usuario Usuario = new Usuario();
            Usuario.Username = textBoxUsername.Text;
            Usuario.Senha = textBoxSenha.Text;
            Usuario.Tipo = comboBoxTipo.SelectedIndex;
            Usuario.DicaSenha = textBoxDica.Text;

            if (Ctr_Usuario.AlterarSenha(Usuario))
            {
                LimparForm();
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

        private void LimparForm()
        {
            textBoxUsername.Text = "";
            textBoxSenha.Text = "";
            comboBoxTipo.SelectedIndex = 0;
            textBoxDica.Text = "";
        }

        private bool ValidarDados()
        {
            string message = string.Empty;
            List<bool> testes = new List<bool>();

            if (string.IsNullOrWhiteSpace(textBoxUsername.Text))
            {
                message += "Campo nome de usuário está vazio.\n";
                testes.Add(false);
            }
            else if (textBoxUsername.Text.Length > 12 || textBoxUsername.Text.Length < 6)
            {
                message += "Campo nome de usuário deve conter no mínimo 6 e no máximo 12 caracteres.\n";
                testes.Add(false);
            }


            if (string.IsNullOrWhiteSpace(textBoxSenha.Text))
            {
                message += "Campo senha está vazio.\n";
                testes.Add(false);
            }
            else if (textBoxSenha.Text.Length > 16 || textBoxSenha.Text.Length < 8)
            {
                message += "Campo senha deve conter no mínimo 8 e no máximo 16 caracteres.\n";
                testes.Add(false);
            }


            if (comboBoxTipo.SelectedItem == null)
            {
                message += "Campo tipo está vazio.\n";
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

        private void comboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
