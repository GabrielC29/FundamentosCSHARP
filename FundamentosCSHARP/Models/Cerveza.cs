using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCSHARP.Models
{
    class Cerveza : Bebida
    {
        public int Alcohol { get; set; }
        public String Marca { get; set; }
        
        public Cerveza(int cantidad,string nombre = "Chelita 10/10") : base(nombre,cantidad)
        {

        }
    }
}
