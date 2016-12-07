

using System;
using System.Windows.Forms;
using Backend.Erro;
using Backend.Basicas;
using Backend;

namespace FrontEnd
{
    public partial class AlterarUsuarioView : Form
    {
        public Fachada f;

        private Usuario usuario = null;

        public AlterarUsuarioView()
        {
            InitializeComponent();
        }

        public AlterarUsuarioView(Usuario usuario)
        {

            InitializeComponent();
            this.loadUser(usuario);
            
        }


        public void loadUser(Usuario usuario) {
            this.tNomeUsuario.Text = usuario.Nome;
            this.usuario = usuario;
        }



        private void button1_Click(object sender, EventArgs e)
        {

            string msg = "";
            try {

                f = Fachada.getInstancia();

                string nome = this.tNomeUsuario.Text;
                if (!usuario.Nome.Equals(nome))
                {
                    usuario.Nome = tNomeUsuario.Text;
                    f.alterarUsuario(usuario);
                }

                msg = "Alterado com sucesso";
                 

            }catch(GeralException g){
                msg = g.Message;
            }
            
            MessageBox.Show(msg);

        }
    }
}
