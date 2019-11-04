using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoTCC.Control;
using ProjetoTCC.Model;

namespace ProjetoTCC.View.Consultas
{
    public partial class View_BuscarUsuario : Form
    {
        public View_BuscarUsuario()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            Ctr_Usuario ctr_Usuario = new Ctr_Usuario();
            Usuario Usuario = new Usuario();
            Usuario.Username = searchBox.Text;

            Usuario = ctr_Usuario.Busca(Usuario);
            searchBox.Text = "";

            if (Usuario == null)
            {
                MessageBox.Show("Não encontramos nenhum usuário com o nome fornecido.", "Não encontrado");
                return;
            }

            View_Usuario view_Usuario = new View_Usuario(Usuario);
            view_Usuario.ShowDialog();
        }

    }
}
