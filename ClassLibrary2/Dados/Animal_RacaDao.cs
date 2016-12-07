using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Basicas;

namespace Backend.Dados
{
    public interface Animal_RacaDao
    {
        List<Animal_Raca> listAnimal_Raca();

        void insertAnimal_Raca(Animal_Raca animal_raca);

        void alterarAnimal_Raca(Animal_Raca animal_raca);

        void deletarAnimal_Raca(Animal_Raca animal_raca);
    }
}
