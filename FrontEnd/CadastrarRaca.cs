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
    public partial class CadastrarRaca : Form
    {
       
        public CadastrarRaca()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient obj = new ServiceReference1.WebService1SoapClient();
            
            Raca raca = new Raca();
            raca.Nome = textBoxNovaRaca.Text;
            obj.insertRaca(raca);
            
            MessageBox.Show("Raça cadastrada com sucesso!");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
