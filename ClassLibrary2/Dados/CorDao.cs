using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Basicas;

namespace Backend.Dados
{
    interface CorDao
    {

        List<Cor> listCor();

        void insertCor(Cor cor);

        void AlterarCor(Cor cor);

        void DeletarCor(Cor cor);

    }
}
