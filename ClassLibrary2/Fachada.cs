using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Basicas;
using Backend.Negocio;

namespace Backend
{
  public class Fachada
    {

               
        
        private static Fachada instancia;
        private UsuarioController usuarioC;
        private ClienteController clienteC;
        private EspecieController especieC;
        private AnimalController animalC;
        private CorController corC;
        private RacaController racaC;
        private Cliente_AnimalController cli_animC;
        private Animal_corController ani_corC;
        private Animal_RacaController ani_racaC;


       
        private Fachada() {
            usuarioC = new UsuarioController();
            clienteC = new ClienteController();
            especieC = new EspecieController();
            animalC = new AnimalController();
            corC = new CorController();
            racaC = new RacaController();
            cli_animC = new Cliente_AnimalController();
            ani_corC = new Animal_corController();
            ani_racaC = new Animal_RacaController();

        }



        public static Fachada getInstancia()
        {
            if (instancia == null)
            {
                instancia = new Fachada();
            }

            return instancia;
        }

        public Usuario FazerLogin(string login, string senha)
        {
            return usuarioC.FazerLogin(login, senha);
        }

        

        public Usuario inserirUsuario(Usuario usuario)
        {

            return usuarioC.cadastrar(usuario);

        }

        public List<Usuario> listarUsuario()
        {
            return usuarioC.listar();
        }
        
        public void alterarUsuario(Usuario usuario)
        {
            usuarioC.alterar(usuario);
        }


        public void deletarUsuario(Usuario usuario)
        {
            usuarioC.deletar(usuario);
        }

       


        /////////////////////////////////////////////



        public void inserirCliente(Cliente cliente)
        {

            clienteC.cadastrar(cliente);

        }

        public List<Cliente> listarCliente()
        {
            return clienteC.listar();
        }


        public void alterCliente(Cliente cliente)
        {
            clienteC.alterar(cliente);
        }


        public void deletarCliente(Cliente cliente)
        {
            clienteC.deletar(cliente);
        }

        /////////////////////////////////// Especie

        public void inserirEspecie(Especie especie)
        {

            especieC.cadastrar(especie);

        }

        public List<Especie> listarEspecie()
        {
            return especieC.listar();
        }


        public void alterarEspecie(Especie especie)
        {
           especieC.alterar(especie);
        }


        public void deletarEspecie(Especie especie)
        {
            especieC.deletar(especie);
        }
        /////////////////////Animal
        public void inserirAnimal(Animal animal)
        {

            animalC.cadastrar(animal);

        }

        public List<Animal> listarAnimal()
        {
            return animalC.listar();
        }


        public void AlterarAnimal(Animal animal)
        {
            animalC.alterar(animal);
        }


        public void deletarAnimal(Animal animal)
        {
            animalC.deletar(animal);
        }


        /////////////Cor
        public void inserirCor(Cor cor)
        {

            corC.Cadastrar(cor);

        }

        public List<Cor> listarCor()
        {
            return corC.listar();
        }


        public void AlterarCar(Cor cor)
        {
            corC.alterar(cor);
        }


        public void deletarCor(Cor cor)
        {
            corC.deletar(cor);
        }

        ////////////////Raca

        public void insertRaca(Raca raca)
        {

            racaC.Cadastrar(raca);

        }

        public List<Raca> listarRaca()
        {
            return racaC.listar();
        }


        public void AlterarRaca(Raca raca)
        {
            racaC.alterar(raca);
        }


        public void deletarRaca(Raca raca)
        {
            racaC.deletar(raca);
        }


        ////////////////////////////Cliente_Animal

        public void insertCliente_Animal(Cliente_Animal cliente_animal)
        {

            cli_animC.cadastrar(cliente_animal);

        }

        public List<Cliente_Animal> listarCliente_Animal()
        {
            return cli_animC.listar();
        }
        ////////////////////////Animal_Cor

        public void insertAnimal_Cor(Animal_Cor animal_cor)
        {

            ani_corC.cadastrar(animal_cor);

        }

        public List<Animal_Cor> listarAnimal_cor()
        {
            return ani_corC.listar();
        }

        ////////////////////Animal_Raca

        public void insertAnimal_Raca(Animal_Raca animal_raca)
        {

            ani_racaC.cadastrar(animal_raca);

        }

        public List<Animal_Raca> listarAnimal_Raca()
        {
            return ani_racaC.listar();
        }




    }
}
