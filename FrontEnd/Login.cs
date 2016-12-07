using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrontEnd.ServiceReference1;


/* namespace FrontEnd
{
    public partial class Login : Form
    {
        private List<Usuario> listlogin = new List<Usuario>();
        private Principal Parent { get; set; }

        public Login(Principal parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        

        private void FazerLogin(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string senha = textBoxSenha.Text;
            Fachada f = Fachada.getInstancia();
            Usuario usuarioLogado = f.FazerLogin(login, senha);
            if(usuarioLogado != null)
            {
                if(usuarioLogado.Senha != senha)
                {
                    MessageBox.Show("Uau! Acho que você errou a senha.");
                    return;
                }
                MessageBox.Show("Login realizado com sucesso!");
                Parent.CarregarUsuario(usuarioLogado);
                this.Close();
            } else
            {
                MessageBox.Show("Ops! Login não encontrado em nossa base de dados!");
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

            CadastroUsuario telaUsuario = new CadastroUsuario();
            telaUsuario.ShowDialog();
            this.Close();
        }

        
    }
}
*/