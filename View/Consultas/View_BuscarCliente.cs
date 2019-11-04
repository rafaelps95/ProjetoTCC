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

namespace ProjetoTCC.View.Consultas
{
    public partial class View_BuscarCliente : Form
    {
        private bool SearchForUsername;
        public View_BuscarCliente(bool searchForUsername)
        {
            InitializeComponent();

            SearchForUsername = searchForUsername;

            if (this.SearchForUsername)
            {
                searchBoxLabel.Text = "Nome de usuário";
            }
            else
            {
                searchBox.Mask = "00000000000000";
                searchBoxLabel.Text = "CPF ou CNPJ (somente números)";
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            Ctr_Cliente Ctr_Cliente = new Ctr_Cliente();
            Cliente Cliente = new Cliente();
            
            if (this.SearchForUsername)
            {
                Cliente.Usuario.Username = searchBox.Text;
            }
            else
            {
                if (searchBox.Text.Length == 11)
                {
                    //searchBox.Mask = "000.000.000-00";
                    Cliente.CPF = searchBox.Text;
                }
                else if (searchBox.Text.Length == 14)
                {
                    //searchBox.Mask = "00.000.000/0000-00";
                    Cliente.CNPJ = searchBox.Text;
                }
                else
                {
                    MessageBox.Show("Insira um CPF ou CNPJ válido. Somente números são permitidos neste campo.", "Somente números são permitidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            Cliente = Ctr_Cliente.Buscar(Cliente);
            searchBox.Text = "";

            if (Cliente == null)
            {
                MessageBox.Show("Não encontramos nenhum cliente cadastrado para os dados fornecidos.", "Não encontrado");
                return;
            }

            View_Cliente View_Cliente = new View_Cliente(Cliente);
            View_Cliente.ShowDialog();
        }
    }
}
