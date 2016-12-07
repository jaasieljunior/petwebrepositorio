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
    public class Animal_RacaController
    {

        private Animal_RacaDaoimp animal_racaDao = null;
       public Animal_RacaController() { }

        public void cadastrar(Animal_Raca animal_Raca)
        {

            try
            {
                this.animal_racaDao = new Animal_RacaDaoimp();
                if (animal_Raca.Equals(null) || animal_Raca.Equals(""))
                {
                    throw new Exception("Objeto Cliente_Animal Nulo");
                }
                this.animal_racaDao.insertAnimal_Raca(animal_Raca);


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
        public List<Animal_Raca> listar()
        {
            try
            {

                Animal_RacaDaoimp animal_cor = new Animal_RacaDaoimp();
                return animal_cor.listAnimal_Raca();
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
