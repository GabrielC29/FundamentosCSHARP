using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCSHARP.Models
{
    public class Bar
    {
        public String Nombre { get; set; }

        public List<Cerveza> chelas = new List<Cerveza>();
        public Bar(String nombre)
        {
            this.Nombre = nombre;
        }

    }
}
