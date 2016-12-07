using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backend;
using Backend.Basicas;


namespace FrontEnd
{
    public partial class NovoCliente : Form
    {
        public NovoCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                Fachada f = Fachada.getInstancia();
                
                Cliente cli = new Cliente();
                cli.Cpf = textBox1.Text;
                cli.Rg = textBox2.Text;
                f.inserirCliente(cli);
                MessageBox.Show("Cliente cadastrado com sucesso!");
                //this.listarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
