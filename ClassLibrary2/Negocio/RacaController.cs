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
    public class RacaController
    {
        private RacaDaoImp racaDaoimp = null;


        public RacaController()
        {

            this.racaDaoimp = new RacaDaoImp();

        }

        public void Cadastrar(Raca raca)
        {

            try
            {
                this.racaDaoimp = new RacaDaoImp();
                if (raca.Equals(null) || raca.Equals(""))
                {
                    throw new Exception("Objeto Raca Nulo");
                }
                this.racaDaoimp.insertRaca(raca);


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



        public void alterar(Raca raca)
        {

            try
            {
                this.racaDaoimp = new RacaDaoImp();
                if (raca.Equals(null) || raca.Equals(""))
                {
                    throw new Exception("Objeto Raca Nulo");
                }
                this.racaDaoimp.AlterarRaca(raca);


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


        public void deletar(Raca raca)
        {

            try
            {
                this.racaDaoimp = new RacaDaoImp();
                if (raca.Equals(null) || raca.Equals(""))
                {
                    throw new Exception("Objeto Raca Nulo");
                }
                this.racaDaoimp.DeletarRaca(raca);


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

        public List<Raca> listar()
        {
            try
            {

                RacaDaoImp racaDao = new RacaDaoImp();
                return racaDao.listRaca();
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
