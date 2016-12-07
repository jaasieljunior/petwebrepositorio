

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Basicas;
using Backend.Dados;
using Backend.Erro;

namespace Backend.Negocio
{
    public class VacinaController
    {

        private VacinaDaoImp vacinaDao = null;

        public VacinaController() { 
            


        }

        
        public void cadastrar(Vacina vacina) {

            try {
                this.vacinaDao = new VacinaDaoImp();
                if (vacina.Equals(null) || vacina.Equals(""))
                {
                    throw new Exception("Não existe vacina no estoque");
                }
                this.vacinaDao.inserirVacina(vacina);
             

             }catch(ConexaoException c){
                throw new GeralException(c.Message);
             }catch(DaoException d){
                throw new GeralException(d.Message);
             }

        }


        public void alterar(Vacina vacina)
        {

            try
            {
                this.vacinaDao = new VacinaDaoImp();
                if (vacina.Equals(null) || vacina.Equals(""))
                {
                    throw new Exception("Objeto Vacina Nulo");
                }
                this.vacinaDao.alterarVacina(vacina);


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


        public void deletar(Vacina vacina)
        {

            try
            {
                this.vacinaDao = new VacinaDaoImp();
                if (vacina.Equals(null) || vacina.Equals(""))
                {
                    throw new Exception("Objeto Vacina Nulo");
                }
                this.vacinaDao.deletarVacina(vacina);


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

        public List<Vacina> listar()
        {
            try{
        
                VacinaDaoImp vacinaDao = new VacinaDaoImp();
                return vacinaDao.listVacina();
            }catch(ConexaoException c){
                throw new GeralException(c.Message);
            }catch(DaoException d){
                throw new GeralException(d.Message);
            }
        
        }

    }
}
