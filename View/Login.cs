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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            this.Text = Sistema.NomedoSistema;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            Autenticar();
        }

        private void Autenticar()
        {
            Ctr_Usuario Ctr_Usuario = new Ctr_Usuario();
            Usuario Usuario = new Usuario();
            Usuario.Username = textBoxUsername.Text;
            Usuario.Senha = textBoxPassword.Text;

            // MODO ADMINISTRATIVO PARA A CRIAÇÃO DOS PRIMEIROS USUÁRIOS
            if (Usuario.Username == "admin" && Usuario.Senha == "%#r76vZ1")
            {
                MessageBox.Show("Use o modo administrativo para criar novos usuários para seus funcionários através do menu \"Usuário > Novo usuário...\".", "Modo administrativo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                IniciarSessao(Usuario);
                return;
            }

            if (Ctr_Usuario.Conectar(Usuario))
            {
                // SOMENTE USUÁRIOS TIPO 0 PODEM ACESSAR O SISTEMA DESKTOP. 0 para funcionários e 1 para clientes
                if (Usuario.Tipo == 1)
                {
                    MessageBox.Show("O usuário informado não possui credenciais necessárias para acesso ao sistema desktop. Clientes devem usar o sistema web ao invés disso.", "Usuário sem privilégios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimparForm();
                    return;
                }

                IniciarSessao(Usuario);
            }
            else
            {
                MessageBox.Show("O nome de usuário e/ou senha fornecidos não conferem. Tente novamente.", "Usuário ou senha incorreto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Usuario = Ctr_Usuario.Busca(Usuario);
                if (Usuario != null)
                {
                    if (string.IsNullOrWhiteSpace(Usuario.DicaSenha) == false)
                        label4.Text = "Dica: " + Usuario.DicaSenha;
                }
            }
        }

        private void IniciarSessao(Usuario Usuario)
        {
            Usuario.Senha = "";
            Ctr_Usuario.UsuarioLogado = Usuario;
            Inicio Inicio = new Inicio();
            Inicio.FormClosed += Inicio_FormClosed;
            Inicio.Show();
            this.Hide();
        }

        private void Inicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            LimparForm();
        }

        private void LimparForm()
        {
            textBoxUsername.Focus();
            textBoxUsername.Text = textBoxPassword.Text = "";
        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Autenticar();
                e.Handled = true;
            }
        }

    }
}
