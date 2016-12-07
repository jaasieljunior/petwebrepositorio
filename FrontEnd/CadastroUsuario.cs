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
    public partial class CadastroUsuario : Form
    {
        
        private List<Usuario> listaUsuario = new List<Usuario>();
        public Usuario usuario;

        

        public CadastroUsuario()
        {
            InitializeComponent();
            

        }


        private void buttonSalvar(object sender, EventArgs e)
        {
            try
            {

                ServiceReference1.WebService1SoapClient obj = new ServiceReference1.WebService1SoapClient();
                Usuario usuario = new Usuario();
                usuario.Nome = txtNome.Text;
                usuario.Telefone = txtTelefone.Text;
                usuario.Email = textBoxEmail.Text;
                usuario.Login = textLogin.Text;
                usuario.Senha = textSenha.Text;
                if(groupBoxAdicionalCliente.Visible)
                {
                    usuario.Tipo = (UsuarioTipo) comboBoxTipo.SelectedIndex; 
                }
                
                Usuario usuarioCadastrado = obj.inserirUsuario(usuario);
                Cliente novoCliente = new Cliente();//(usuarioCadastrado.Id, textBoxRG.Text, textBoxCPF.Text);
                novoCliente.Id = usuarioCadastrado.Id;
                novoCliente.CPF = textBoxCPF.Text;
                novoCliente.RG = textBoxRG.Text;
                obj.inserirCliente(novoCliente);
                MessageBox.Show("Usuario cadastrado com sucesso!");
                this.Close();
                Principal p = new Principal();
                p.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void comboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBoxTipo = (ComboBox)sender;
            int indexSelected = comboBoxTipo.SelectedIndex;
            Console.Write(indexSelected);
            switch (indexSelected)
            {
                case 0:
                    ShowHideFieldsForCliente();
                    break;
                case 1:
                    ShowHideFieldsForVeterinario();
                    break;
                default:
                    MessageBox.Show("Opção selecionada não existe!");
                    break;
            }
        }





        private void ShowHideFieldsForCliente()
        {
            if (groupBoxAdicionalVeterinario.Visible)
                groupBoxAdicionalVeterinario.Visible = !groupBoxAdicionalVeterinario.Visible;
            groupBoxAdicionalCliente.Visible = !groupBoxAdicionalCliente.Visible;
        }

        private void ShowHideFieldsForVeterinario()
        {
            if (groupBoxAdicionalCliente.Visible)
                groupBoxAdicionalCliente.Visible = !groupBoxAdicionalCliente.Visible;
            groupBoxAdicionalVeterinario.Visible = !groupBoxAdicionalVeterinario.Visible;
        }
    }
}

