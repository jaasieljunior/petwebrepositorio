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
    public partial class CadastrarCor : Form
    {
        
        public CadastrarCor()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonInserirCor_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient obj = new ServiceReference1.WebService1SoapClient();
            Cor cor = new Cor();
            cor.Nome = textBoxNovaCor.Text;
            obj.inserirCor(cor);
            MessageBox.Show("Cor cadastrada com sucesso!");
        }
    }
}
