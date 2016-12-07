using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Basicas
{
   public class Animal_Raca
    {
        private int id;
        private Animal animal_id;
        private Raca raca_id;

        public Animal_Raca() {

            this.animal_id = new Animal();
            this.raca_id = new Raca();

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

        public Raca Raca_id
        {
            get
            {
                return raca_id;
            }

            set
            {
                raca_id = value;
            }
        }
    }
}
