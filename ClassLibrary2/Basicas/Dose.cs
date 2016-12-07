using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Basicas
{
    public class Dose
    {
        private int id;
        private string dosagem;
        private float numero;
        private DateTime dataCadastro;

       

        public Dose() { }

        public Dose(int id, string dosagem, float numero, DateTime dataCadastro )
        {
            this.id = id;
            this.dosagem = dosagem;
            this.numero = numero;
            this.dataCadastro = dataCadastro;
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

        public DateTime DataCadastro
        {
            get { return dataCadastro; }
            set { dataCadastro = value; }
        }

        public string Dosagem
        {
            get
            {
                return dosagem;
            }

            set
            {
                dosagem = value;
            }
        }

        public float Numero
        {
            get
            {
                return numero;
            }

            set
            {
                numero = value;
            }
        }
    }
}
