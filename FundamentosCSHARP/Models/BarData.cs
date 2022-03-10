using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCSHARP.Models
{
    public class BarData
    {
        public String Nombre { get; set; }
        public List<Bebida> bebidas = new List<Bebida>();
        public BarData(String nombre)
        {
            this.Nombre = nombre;
        }
    }
}
