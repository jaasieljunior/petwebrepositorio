using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Basicas;

namespace Backend.Dados
{
   public interface Cliente_AnimalDao
    {

        List<Cliente_Animal> listCliente_Animal();

        void insertCliente_Animal(Cliente_Animal cliente_animal);

        void alterarCliente_Animal(Cliente_Animal cliente_animal);

        void deletarCliente_Animal(Cliente_Animal cliente_animal);

    }
}
