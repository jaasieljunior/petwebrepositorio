using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Basicas
{
    public class Periodicidade
    {
        private int id;
        private int qtdeDias;

        public Periodicidade() { }

        public Periodicidade(int id, int qtdeDias)
        {
            this.id = id;
            this.qtdeDias = qtdeDias;
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

        public int QtdeDias
        {
            get
            {
                return qtdeDias;
            }

            set
            {
                qtdeDias = value;
            }
        }
    }
}
