using System;
using System.Windows.Forms;
using Backend;
using Backend.Basicas;




namespace FrontEnd
{
    public partial class CadastrarClienteView : Form
    {
        Fachada f;
        public CadastrarClienteView()
        {
            InitializeComponent();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            f = Fachada.getInstancia();
            Cliente cliente = new Cliente();
            cliente.Cpf = (TextBoxCpf.Text);
            cliente.Rg = (TextBoxRg.Text);
            f.inserirCliente(cliente);
            MessageBox.Show("Cliente cadastrado com sucesso!");
            //this.listarUsuarios();
        }
    }
}
