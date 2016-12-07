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
    public partial class NovoUsuario : Form
    {

        private List<Usuario> listaUsuario = new List<Usuario>();
        
        
        public NovoUsuario()
        {
            InitializeComponent();
            listarUsuarios();
            
        }


        private void listarUsuarios() {
           try
            {

                Fachada f = Fachada.getInstancia();

               this.listaUsuario = f.listarUsuario();

               listView1.Items.Clear();
               foreach (Usuario usuario in this.listaUsuario)
               {
                  ListViewItem item =  listView1.Items.Add("" + usuario.Id);
                  item.SubItems.Add(usuario.Nome);
                  item.SubItems.Add(usuario.Telefone);
               }
 
           }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                Fachada f = Fachada.getInstancia();
                Usuario usuario = new Usuario();
                Cliente cli = new Cliente();
                usuario.Nome = textBox1.Text;
                usuario.Telefone = textBox2.Text;
                usuario.Login = textBox3.Text;
                usuario.Senha = textBox4.Text;
                f.inserirUsuario(usuario);   
                MessageBox.Show("Usuario cadastrado com sucesso!");
                this.listarUsuarios();    
            }
            catch (Exception ex) {
               MessageBox.Show(ex.Message);
            } 



        }
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
        
            int test = Convert.ToInt32(listView1.SelectedItems[0].Index.ToString());
            AlterarUsuarioView fAlterarUsuario = new AlterarUsuarioView(this.listaUsuario[test]);
            fAlterarUsuario.ShowDialog();
            listView1.SelectedItems[0].SubItems[1].Text = this.listaUsuario[test].Nome;  
            //listarUsuarios();
            //
        
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
                  }

        private void button2_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0) {

                int test = Convert.ToInt32(listView1.SelectedItems[0].Index.ToString());
                DialogResult dialogResult = MessageBox.Show("Deseja deletar Usuário " + this.listaUsuario[test].Nome.ToString(),"Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) {
                    Fachada f = Fachada.getInstancia();
                    f.deletarUsuario(this.listaUsuario[test]);
                   // listarUsuarios();
                    listView1.SelectedItems[0].Remove();
                }
                
            }
            
            

        }

        

    }
}
