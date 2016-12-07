using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Basicas
{
   public class Animal_Cor
    {
        private int id;
        private Animal animal_id;
        private Cor cor_id;

        public Animal_Cor()
        {

            this.Animal_id = new Animal();
            this.cor_id = new Cor();
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

        public Animal Animal_id
        {
            get
            {
                return animal_id;
            }

            set
            {
                animal_id = value;
            }
        }

        public Cor Cor_id
        {
            get
            {
                return cor_id;
            }

            set
            {
                cor_id = value;
            }
        }
    }
}
