using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Basicas
{
    public class Vacina
    {

        private int id;
        private string nome;
        private string descricao;
        private Doenca doenca;
        private Periodicidade periodicidade;


        public Vacina() {
            this.doenca = new Doenca();
            this.periodicidade = new Periodicidade();
        }

        public Vacina(int id, string nome, string descricao, Doenca doenca, Periodicidade periodicidade)
        {
            this.id = id;
            this.nome = nome;
            this.descricao = descricao;
            this.doenca = doenca;
            this.Periodicidade = periodicidade;
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

        public string Descricao
        {
            get
            {
                return descricao;
            }

            set
            {
                descricao = value;
            }
        }

        public Doenca Doenca
        {
            get
            {
                return doenca;
            }

            set
            {
                doenca = value;
            }
        }

        public Periodicidade Periodicidade
        {
            get
            {
                return periodicidade;
            }

            set
            {
                periodicidade = value;
            }
        }
    }
}
