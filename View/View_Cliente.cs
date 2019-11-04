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
    public partial class View_Cliente : Form
    {
        private Cliente clienteEncontrado;
        public View_Cliente()
        {
            InitializeComponent();
        }

        public View_Cliente(Cliente Cliente)
        {
            InitializeComponent();

            buttonEnviar.Visible = false;
            buttonAlterar.Visible = buttonExcluir.Visible = true;

            ExibirDados(Cliente);
        }

        public View_Cliente(string documento, bool isCPF)
        {
            InitializeComponent();

            if (isCPF == true)
            {
                radioButtonPF.Checked = true;
                textBoxCPF.Text = documento;
            }
            else
            {
                radioButtonPJ.Checked = true;
                textBoxCNPJ.Text = documento;
            }
        }

        private void radioButtonPF_CheckedChanged(object sender, EventArgs e)
        {
            //LimparForm();

            if (radioButtonPF.Checked)
            {
                radioButtonPJ.Checked = false;
                textBoxDataNasc.Enabled = true;
                textBoxCPF.Enabled = true;
                textBoxCNPJ.Enabled = false;
                textBoxCNPJ.Text = "";
            }
        }

        private void radioButtonPJ_CheckedChanged(object sender, EventArgs e)
        {
            //LimparForm();

            if (radioButtonPJ.Checked)
            {
                radioButtonPF.Checked = false;
                textBoxDataNasc.Enabled = false;
                textBoxDataNasc.Text = "";
                textBoxCPF.Enabled = false;
                textBoxCPF.Text = "";
                textBoxCNPJ.Enabled = true;
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            Cliente Cliente = new Cliente();

            // Se o tipo de cliente selecionado for pessoa jurídica, deve-se usar o CNPJ inserido. 
            //Caso contrário deve-se usar o CPF.
            if (radioButtonPJ.Checked)
            {
                Cliente.Tipo = 1;
                Cliente.CNPJ = textBoxCNPJ.Text;
            }
            else
            {
                Cliente.Tipo = 0;
                Cliente.CPF = textBoxCPF.Text;
            }

            if (textBoxUser.Text != "")
            {
                Cliente.Usuario.Username = textBoxUser.Text;
            }

            BuscarCliente(Cliente);
        }

        private void BuscarCliente(Cliente Cliente)
        {
            Ctr_Cliente Ctr_Cliente = new Ctr_Cliente();
            ExibirDados(Ctr_Cliente.Buscar(Cliente));
        }

        private void ExibirDados(Cliente Cliente)
        {
            clienteEncontrado = Cliente;

            if (Cliente != null)
            {
                textBoxNome.Text = Cliente.Nome;

                if (Cliente.Tipo == 0)
                {
                    radioButtonPF.Checked = true;
                    textBoxCPF.Text = Convert.ToString(Cliente.CPF);
                    textBoxCNPJ.Text = "";
                    textBoxDataNasc.Text = Cliente.DataNasc.ToShortDateString();
                }
                else
                {
                    radioButtonPJ.Checked = true;
                    textBoxCPF.Text = "";
                    textBoxCNPJ.Text = Convert.ToString(Cliente.CNPJ);
                    textBoxDataNasc.Text = "";
                }

                textBoxEmail.Text = Cliente.Email;
                textBoxFone.Text = Cliente.Telefone;
                textBoxUser.Text = Cliente.Usuario.Username;
                textBoxUser.Enabled = false;
            }
            else
            {
                LimparForm();
            }
        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            if (ValidarDados() == false)
                return;

            Ctr_Cliente Ctr_Cliente = new Ctr_Cliente();
            Cliente Cliente = new Cliente();

            try
            {
                Cliente.DataNasc = DateTime.Parse(textBoxDataNasc.Text);
            }
            catch
            {

            }

            Cliente.Email = textBoxEmail.Text;
            Cliente.Nome = textBoxNome.Text;
            Cliente.Telefone = textBoxFone.Text;

            textBoxCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            textBoxCNPJ.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (radioButtonPF.Checked)
            {
                Cliente.Tipo = 0;
                Cliente.CPF = textBoxCPF.Text;
            }
            else
            {
                Cliente.Tipo = 1;
                Cliente.CNPJ = textBoxCNPJ.Text;
            }

            textBoxCPF.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            textBoxCNPJ.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

            Ctr_Usuario ctr_Usuario = new Ctr_Usuario();
            Cliente.Usuario.Username = textBoxUser.Text;
            Cliente.Usuario.Tipo = 1;
            if (ctr_Usuario.Busca(Cliente.Usuario) == null)
            {
                ctr_Usuario.Adicionar(Cliente.Usuario);
            }
            else
            {
                MessageBox.Show("O nome de usuário informado já existe. Por favor, insira outro.", "Usuário já existe");
                return;
            }

            if (Ctr_Cliente.Adicionar(Cliente))
            {
                LimparForm();
                MessageBox.Show("Cliente adicionado com êxito!");
                this.Close();
                return;
            }
            else
            {
                MessageBox.Show("Não foi possível se comunicar com o banco de dados. Pode haver algo errado com sua conexão com a rede ou os dados fornecidos não foram aceitos.", "Não foi possível realizar a operação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show("Para efetuar o primeiro acesso na plataforma online, o usuário deverá informar os primeiros 4 dígitos do seu documento cadastrado.", "Dicas para primeiro acesso");
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            Ctr_Cliente Ctr_Cliente = new Ctr_Cliente();

            if (Ctr_Cliente.Excluir(clienteEncontrado))
            {
                LimparForm();
                MessageBox.Show("Cliente excluído com sucesso!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Não foi possível se comunicar com o banco de dados. Pode haver algo errado com sua conexão com a rede ou os dados fornecidos não foram aceitos.", "Não foi possível realizar a operação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LimparForm()
        {
            textBoxNome.Text = "";
            textBoxCPF.Text = "";
            textBoxCNPJ.Text = "";
            textBoxDataNasc.Text = "";
            textBoxEmail.Text = "";
            textBoxFone.Text = "";
            textBoxUser.Text = "";

            //radioButtonPF.Checked = true;
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            LimparForm();
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            if (ValidarDados() == false)
                return;

            Ctr_Cliente Ctr_Cliente = new Ctr_Cliente();
            Cliente Cliente = new Cliente();


            try
            {
                Cliente.DataNasc = DateTime.Parse(textBoxDataNasc.Text);
            }
            catch
            {

            }

            Cliente.Email = textBoxEmail.Text;
            Cliente.Nome = textBoxNome.Text;
            Cliente.Telefone = textBoxFone.Text;

            if (radioButtonPF.Checked)
            {
                Cliente.Tipo = 0;
                Cliente.CPF = textBoxCPF.Text;
            }
            else
            {
                Cliente.CNPJ = textBoxCNPJ.Text;
                Cliente.Tipo = 1;
            }

            Cliente.Usuario.Username = textBoxUser.Text;

            Ctr_Cliente.Alterar(Cliente);
        }

        private bool ValidarDados()
        {
            string message = string.Empty;
            List<bool> testes = new List<bool>();

            textBoxCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            textBoxCNPJ.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            textBoxFone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (string.IsNullOrWhiteSpace(textBoxNome.Text))
            {
                message += "Campo nome está vazio.\n";
                testes.Add(false);
            }

            if (radioButtonPF.Checked)
            {
                try
                {
                    DateTime dt = DateTime.Parse(textBoxDataNasc.Text);
                    if (Ctr_Cliente.GetAge(dt) < 18)
                    {
                        message += "Somente maiores de 18 anos podem usar o sistema.\n";
                        testes.Add(false);
                        //MessageBox.Show("Somente maiores de 18 anos podem usar o sistema.", "Tente novamente quando você se tornar maior de idade!! :)");
                    }
                }
                catch
                {
                    message += "Campo data está em um formato inválido.\n";
                    testes.Add(false);
                }

                if (string.IsNullOrWhiteSpace(textBoxCPF.Text))
                {
                    message += "Campo CPF está vazio.\n";
                    testes.Add(false);
                }

            }
            else
            {
                if (string.IsNullOrWhiteSpace(textBoxCNPJ.Text))
                {
                    message += "Campo CNPJ está vazio.\n";
                    testes.Add(false);
                }
            }

            if (string.IsNullOrWhiteSpace(textBoxFone.Text))
            {
                message += "Campo telefone está vazio.\n";
                testes.Add(false);
            }

            if (string.IsNullOrWhiteSpace(textBoxUser.Text))
            {
                message += "Campo usuário está vazio.\n";
                testes.Add(false);
            }
            //else if (string.IsNullOrWhiteSpace())

            textBoxCPF.TextMaskFormat = MaskFormat.IncludeLiterals;
            textBoxCNPJ.TextMaskFormat = MaskFormat.IncludeLiterals;
            textBoxFone.TextMaskFormat = MaskFormat.IncludeLiterals;

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
