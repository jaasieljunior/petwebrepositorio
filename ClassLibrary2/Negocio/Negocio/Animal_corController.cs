using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Erro;
using Backend.Dados;
using Backend.Basicas;

namespace Backend.Negocio
{
   public  class Animal_corController
    {

        private Animal_CorDaoImp animal_corDao = null;

        public Animal_corController()
        {

        }
        public void cadastrar(Animal_Cor animal_cor)
        {

            try
            {
                this.animal_corDao = new Animal_CorDaoImp();
                if (animal_cor.Equals(null) || animal_cor.Equals(""))
                {
                    throw new Exception("Objeto Cliente_Animal Nulo");
                }
                this.animal_corDao.insertAnimal_Cor(animal_cor);


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
        public List<Animal_Cor> listar()
        {
            try
            {

                Animal_CorDaoImp animal_cor = new Animal_CorDaoImp();
                return animal_cor.listAnimal_Cor();
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
