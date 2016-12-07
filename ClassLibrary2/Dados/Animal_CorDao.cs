using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Basicas;

namespace Backend.Dados
{
    public interface Animal_CorDao
    {

        List<Animal_Cor> listAnimal_Cor();

        void insertAnimal_Cor(Animal_Cor animal_cor);

        void alterarAnimal_Cor(Animal_Cor animal_cor);

        void deletarAnimal_Cor(Animal_Cor animal_cor);
    }
}
