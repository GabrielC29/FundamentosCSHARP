using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCSHARP.Models
{
    public class Cerveza : Bebida
    {
        public int Alcohol { get; set; }
        public String Marca { get; set; }
        public int id { get; set; }

        public Cerveza() : base(null,0)
        {

        }
        public Cerveza(int cantidad,string nombre = "Chelita 10/10") : base(nombre,cantidad)
        {

        }
    }
}
