using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Backend;
using Backend.Basicas;
using Backend.Negocio;


namespace WebApplication4
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        public Fachada fachada = null;
        

        public WebService1()
        {

            this.fachada = Fachada.getInstancia();
            
        }


        
        [WebMethod]
        public Usuario FazerLogin(string login, string senha)
        {
            return fachada.FazerLogin(login, senha);
        }


        [WebMethod]
        public Usuario inserirUsuario(Usuario usuario)
        {

            return fachada.inserirUsuario(usuario);

        }
        [WebMethod]
        public List<Usuario> listarUsuario()
        {
            return fachada.listarUsuario();
        }
        [WebMethod]
        public void alterarUsuario(Usuario usuario)
        {
            fachada.alterarUsuario(usuario);
        }

        [WebMethod]
        public void deletarUsuario(Usuario usuario)
        {
            fachada.deletarUsuario(usuario);
        }




        /////////////////////////////////////////////


        [WebMethod]
        public void inserirCliente(Cliente cliente)
        {

            fachada.inserirCliente(cliente);

        }
        [WebMethod]
        public List<Cliente> listarCliente()
        {
            return fachada.listarCliente();
        }

        [WebMethod]
        public void alterCliente(Cliente cliente)
        {
            fachada.alterCliente(cliente);
        }

        [WebMethod]
        public void deletarCliente(Cliente cliente)
        {
            fachada.deletarCliente(cliente);
        }

        /////////////////////////////////// Especie
        [WebMethod]
        public void inserirEspecie(Especie especie)
        {

            fachada.inserirEspecie(especie);

        }
        [WebMethod]
        public List<Especie> listarEspecie()
        {
            return fachada.listarEspecie();
        }

        [WebMethod]
        public void alterarEspecie(Especie especie)
        {
            fachada.alterarEspecie(especie);
        }

        [WebMethod]
        public void deletarEspecie(Especie especie)
        {
            fachada.deletarEspecie(especie);
        }
        /////////////////////Animal
        [WebMethod]
        public void inserirAnimal(Animal animal)
        {

            fachada.inserirAnimal(animal);

        }
        [WebMethod]
        public List<Animal> listarAnimal()
        {
            return fachada.listarAnimal();
        }

        [WebMethod]
        public void AlterarAnimal(Animal animal)
        {
            fachada.AlterarAnimal(animal);
        }

        [WebMethod]
        public void deletarAnimal(Animal animal)
        {
            fachada.deletarAnimal(animal);
        }


        /////////////Cor
        [WebMethod]
        public void inserirCor(Cor cor)
        {

            fachada.inserirCor(cor);

        }
        [WebMethod]
        public List<Cor> listarCor()
        {
            return fachada.listarCor();
        }

        [WebMethod]
        public void AlterarCar(Cor cor)
        {
            fachada.AlterarCar(cor);
        }

        [WebMethod]
        public void deletarCor(Cor cor)
        {
            fachada.deletarCor(cor);
        }

        ////////////////Raca
        [WebMethod]
        public void insertRaca(Raca raca)
        {

            fachada.insertRaca(raca);

        }
        [WebMethod]
        public List<Raca> listarRaca()
        {
            return fachada.listarRaca();
        }

        [WebMethod]
        public void AlterarRaca(Raca raca)
        {
            fachada.AlterarRaca(raca);
        }

        [WebMethod]
        public void deletarRaca(Raca raca)
        {
            fachada.deletarRaca(raca);
        }


        ////////////////////////////Cliente_Animal
        [WebMethod]
        public void insertCliente_Animal(Cliente_Animal cliente_animal)
        {

            fachada.insertCliente_Animal(cliente_animal);

        }
        [WebMethod]
        public List<Cliente_Animal> listarCliente_Animal()
        {
            return fachada.listarCliente_Animal();
        }
        ////////////////////////Animal_Cor
        [WebMethod]
        public void insertAnimal_Cor(Animal_Cor animal_cor)
        {

            fachada.insertAnimal_Cor(animal_cor);

        }
        [WebMethod]
        public List<Animal_Cor> listarAnimal_cor()
        {
            return fachada.listarAnimal_cor();
        }

        ////////////////////Animal_Raca
        [WebMethod]
        public void insertAnimal_Raca(Animal_Raca animal_raca)
        {

            fachada.insertAnimal_Raca(animal_raca);

        }
        [WebMethod]
        public List<Animal_Raca> listarAnimal_Raca()
        {
            return fachada.listarAnimal_Raca();
        }

    }
}
