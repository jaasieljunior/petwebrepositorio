using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Basicas;
using Backend.Erro;
using Backend.Util;

namespace Backend.Dados
{
    public interface RacaDao
    {
        List<Raca> listRaca();

        void insertRaca(Raca raca);

        void AlterarRaca(Raca raca);

        void DeletarRaca(Raca raca);

    }
}
