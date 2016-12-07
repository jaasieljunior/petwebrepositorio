using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Basicas;

namespace Backend.Dados
{
    public interface AnimalDao
    {
        List<Animal> listAnimal();

        void inserirAnimal(Animal animal);

        void alterarAnimal(Animal animal);

        void deletarAnimal(Animal animal);

    }
}
