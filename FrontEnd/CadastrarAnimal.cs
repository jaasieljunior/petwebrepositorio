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
    public partial class CadastrarAnimal : Form
    {

        public CadastrarAnimal()
        {
            InitializeComponent();
            listarEspecie();

        }

        private void buttonNovaEspecie_Click(object sender, EventArgs e)
        {
            CadastrarEspecieView cadastrarEspecie = new CadastrarEspecieView();
            cadastrarEspecie.Show();
        }

        private void ButtonNovaRaca_Click(object sender, EventArgs e)
        {
            CadastrarRaca cadastrarRaca = new CadastrarRaca();
            cadastrarRaca.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastrarCor cadastraCor = new CadastrarCor();
            cadastraCor.Show();
        }

        private void ButtonInserir_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient obg = new ServiceReference1.WebService1SoapClient();
            Animal animal = new Animal();
            Cliente cliente = new Cliente();
            animal.Nome = textBoxAnimalNome.Text;
            animal.Peso = Convert.ToInt32(textBoxPeso.Text);
            animal.Idade = Convert.ToInt32(textBoxIdade.Text);
            Especie especie = new Especie();
            animal.Especie.Id = comboBoxEspecie.SelectedIndex;
            obg.inserirAnimal(animal);

            Raca raca = new Raca();
            raca.Id = comboBoxRaça.SelectedIndex;
            obg.insertRaca(raca);

            //comboBoxCor.
          


            MessageBox.Show("Animal cadastrada com sucesso!");
        }
        public void loadComboBoxCor()
        {


            ServiceReference1.WebService1SoapClient obg = new ServiceReference1.WebService1SoapClient();


            comboBoxCor.DataSource = obg.listarCor();
            comboBoxCor.DisplayMember = "Exibicao";
            comboBoxCor.ValueMember = "Abreviatura";

        }


        private void CadastrarAnimal_Load(object sender, EventArgs e)
        {




        }

        private void listarEspecie()
        {
            try
            {
                ServiceReference1.WebService1SoapClient obg = new ServiceReference1.WebService1SoapClient();

                comboBoxEspecie.DataSource = obg.listarEspecie();
                comboBoxEspecie.DisplayMember = "Nome";
                comboBoxEspecie.ValueMember = "Id";
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }


        }

        private void comboBoxEspecie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxRaça_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxCor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButtonNovaCor_Click(object sender, EventArgs e)
        {
            CadastrarCor cadastraCor = new CadastrarCor();
            cadastraCor.Show();
        }
    }
}
