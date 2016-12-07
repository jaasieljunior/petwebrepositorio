using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Basicas
{
    public class Cliente { 

        public int Id { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }

        public Cliente(int id, string cpf, string rg)
        {
            Id = id;
            CPF = cpf;
            RG = rg;
        }

        public Cliente()
        {
        }
    }
}

