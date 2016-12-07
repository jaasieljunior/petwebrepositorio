using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Basicas;

namespace Backend.Dados
{

     
    interface VacinaDao 
    {


        
        List<Vacina> listVacina();

       
        void inserirVacina(Vacina vacina);

        
        void alterarVacina(Vacina vacina);

        
        void deletarVacina(Vacina vacina);


        
    }
}
