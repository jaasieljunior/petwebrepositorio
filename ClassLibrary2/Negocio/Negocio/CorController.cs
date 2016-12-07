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
    public class CorController
    {
        private CorDaoImp corDaoImp = null;

        public CorController()
        {

            this.corDaoImp = new CorDaoImp();

        }

        public void Cadastrar(Cor cor)
        {

            try
            {
                this.corDaoImp = new CorDaoImp();
                if (cor.Equals(null) || cor.Equals(""))
                {
                    throw new Exception("Objeto Cor Nulo");
                }
                this.corDaoImp.insertCor(cor);


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



        public void alterar(Cor cor)
        {

            try
            {
                this.corDaoImp = new CorDaoImp();
                if (cor.Equals(null) || cor.Equals(""))
                {
                    throw new Exception("Objeto Usuario Nulo");
                }
                this.corDaoImp.AlterarCor(cor);


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


        public void deletar(Cor cor)
        {

            try
            {
                this.corDaoImp = new CorDaoImp();
                if (cor.Equals(null) || cor.Equals(""))
                {
                    throw new Exception("Objeto Animal Nulo");
                }
                this.corDaoImp.DeletarCor(cor);


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

        public List<Cor> listar()
        {
            try
            {

                CorDaoImp corDao = new CorDaoImp();
                return corDao.listCor();
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
