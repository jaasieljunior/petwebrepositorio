using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Dados;
using Backend.Basicas;
using Backend.Erro;



namespace Backend.Negocio
{
    public class AnimalController
    {


        private AnimalDaoImp animalDaoImp = null;

        public AnimalController()
        {

            this.animalDaoImp = new AnimalDaoImp();
            
        }

        public void cadastrar(Animal animal)
        {

            try
            {
                this.animalDaoImp = new AnimalDaoImp();
                if (animal.Equals(null) || animal.Equals(""))
                {
                    throw new Exception("Objeto Animal Nulo");
                }
                this.animalDaoImp.insertAnimal(animal);


            }
            catch (ConexaoException c)
            {
                throw new GeralException(c.Message);
            }
            catch (DaoException d)
            {
                throw new GeralException(d.Message);
            }

        }



        public void alterar(Animal animal)
        {

            try
            {
                this.animalDaoImp = new AnimalDaoImp();
                if (animal.Equals(null) || animal.Equals(""))
                {
                    throw new Exception("Objeto Usuario Nulo");
                }
                this.animalDaoImp.alterarAnimal(animal);


            }
            catch (ConexaoException c)
            {
                throw new GeralException(c.Message);
            }
            catch (DaoException d)
            {
                throw new GeralException(d.Message);
            }

        }


        public void deletar(Animal animal)
        {

            try
            {
                this.animalDaoImp = new AnimalDaoImp();
                if (animal.Equals(null) || animal.Equals(""))
                {
                    throw new Exception("Objeto Animal Nulo");
                }
                this.animalDaoImp.deletarAnimal(animal);


            }
            catch (ConexaoException c)
            {
                throw new GeralException(c.Message);
            }
            catch (DaoException d)
            {
                throw new GeralException(d.Message);
            }

        }

        public List<Animal> listar()
        {
            try
            {

                AnimalDaoImp animaldao = new AnimalDaoImp();
                return animaldao.listAnimal();
            }
            catch (ConexaoException c)
            {
                throw new GeralException(c.Message);
            }
            catch (DaoException d)
            {
                throw new GeralException(d.Message);
            }

        }





    }
}
