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
    public class Cliente_AnimalController
    {
        private Cliente_AnimalDaoImp cleiente_AnimalDao = null; 
        
      public Cliente_AnimalController() {

      }
        public void cadastrar(Cliente_Animal cliente_animal)
        {

            try
            {
                this.cleiente_AnimalDao = new Cliente_AnimalDaoImp();
                if (cliente_animal.Equals(null) || cliente_animal.Equals(""))
                {
                    throw new Exception("Objeto Cliente_Animal Nulo");
                }
                this.cleiente_AnimalDao.insertCliente_Animal(cliente_animal);


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
        public List<Cliente_Animal> listar()
        {
            try
            {

                Cliente_AnimalDaoImp cli_animal = new Cliente_AnimalDaoImp();
                return cli_animal.listCliente_Animal();
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


    

