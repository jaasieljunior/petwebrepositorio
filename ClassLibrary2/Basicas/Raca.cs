using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Backend.Basicas
{
   public class Raca
    {
        private int id;
        private string nome;
        
        private DateTime data_cadastro;

        public Raca() {

        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        

        public DateTime Data_cadastro
        {
            get
            {
                return data_cadastro;
            }

            set
            {
                data_cadastro = value;
            }
        }
    }
}
