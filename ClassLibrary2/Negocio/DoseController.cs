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
    public class DoseController
    {



        private DoseDaoImp doseDao = null;

        public DoseController() { 
            


        }

        
        public void cadastrar(Dose dose) {

            try {
                this.doseDao = new DoseDaoImp();
                if (dose.Equals(null) || dose.Equals(""))
                {
                    throw new Exception("Objeto Dose Nulo");
                }
                this.doseDao.insertDose(dose);
             

             }catch(ConexaoException c){
                throw new GeralException(c.Message);
             }catch(DaoException d){
                throw new GeralException(d.Message);
             }

        }


        public void alterar(Dose Dose)
        {

            try
            {
                this.doseDao = new DoseDaoImp();
                if (Dose.Equals(null) || Dose.Equals(""))
                {
                    throw new Exception("Objeto Dose Nulo");
                }
                this.doseDao.alterarDose(Dose);


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


        public void deletar(Dose dose)
        {

            try
            {
                this.doseDao = new DoseDaoImp();
                if (dose.Equals(null) || dose.Equals(""))
                {
                    throw new Exception("Objeto Dose Nulo");
                }
                this.doseDao.deletarDose(dose);


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

        public List<Dose> listar()
        {
            try{
        
                DoseDaoImp doseDao = new DoseDaoImp();
                return doseDao.listDose();
            }catch(ConexaoException c){
                throw new GeralException(c.Message);
            }catch(DaoException d){
                throw new GeralException(d.Message);
            }
        
        }

    }
}
