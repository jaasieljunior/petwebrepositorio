using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Basicas
{
  public  class Cliente_Animal
    {
        private int id;
        private Animal animal_id;
        private Cliente cliente_id;

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

        public Cliente Cliente_id
        {
            get
            {
                return cliente_id;
            }

            set
            {
                cliente_id = value;
            }
        }

        public Cliente_Animal() {

            this.Animal_id = new Animal();
         //   this.Cliente_id = new Cliente();
        }


    }
}
