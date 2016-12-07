using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrontEnd.ServiceReference1;

namespace FrontEnd
{
    public partial class Principal : Form
    {

        public Principal()
        {
            InitializeComponent();
            //Login login = new Login(this);
           // login.Show();
        }


        public void CarregarUsuario(Usuario usuario)
        {
            menuStrip.Visible = true;
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadastrarAnimal cadastrarAnimal = new CadastrarAnimal();
            cadastrarAnimal.Show();
        }

        private void novoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CadastrarCor novaCor = new CadastrarCor();
            novaCor.Show();
        }

        private void novoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            CadastrarRaca novaRaca = new CadastrarRaca();
            novaRaca.Show();
        }

        private void novoToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            CadastrarEspecieView novaEspecie = new CadastrarEspecieView();
            novaEspecie.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroUsuario u = new CadastroUsuario();
            u.Show();
        }

        private void alterarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
