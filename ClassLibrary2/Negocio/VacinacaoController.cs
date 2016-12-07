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
    public class VacinacaoController
    {


         
        private VacinacaoDaoImp vacinacaoDao = null;

        public VacinacaoController() { 
            


        }

        
        public void cadastrar(Vacinacao vacinacao) {

            try {
                this.vacinacaoDao = new VacinacaoDaoImp();
                if (vacinacao.Equals(null) || vacinacao.Equals(""))
                {
                    throw new Exception("Objeto Vacinacao Nulo");
                }

               // validar 
               // vacinacao.Animal
               // vacinacao.Veterinario
               // vacinacao.LDoseVacina


                this.vacinacaoDao.insertVacinacao(vacinacao);
             

             }catch(ConexaoException c){
                throw new GeralException(c.Message);
             }catch(DaoException d){
                throw new GeralException(d.Message);
             }

        }


        public void alterar(Vacinacao vacinacao)
        {

            try
            {
                this.vacinacaoDao = new VacinacaoDaoImp();
                if (vacinacao.Equals(null) || vacinacao.Equals(""))
                {
                    throw new Exception("Objeto vacinacao Nulo");
                }
                this.vacinacaoDao.updateVacinacao(vacinacao);


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


        public void deletar(Vacinacao vacinacao)
        {

            try
            {
                this.vacinacaoDao = new VacinacaoDaoImp();
                if (vacinacao.Equals(null) || vacinacao.Equals(""))
                {
                    throw new Exception("Objeto vacinacao Nulo");
                }
                this.vacinacaoDao.deleteVacinacao(vacinacao);


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

        public List<Vacinacao> listar()
        {
            try{

                VacinacaoDaoImp vacinacaoDao = new VacinacaoDaoImp();
                return vacinacaoDao.listVacinacao();
            }catch(ConexaoException c){
                throw new GeralException(c.Message);
            }catch(DaoException d){
                throw new GeralException(d.Message);
            }
        
        }

    }
}
