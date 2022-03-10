using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using FundamentosCSHARP.Models;
using FundamentosCSHARP.Errors;

namespace FundamentosCSHARP.Service
{
    public class BuscarChela
    {
        List<Cerveza> chelas = new List<Cerveza>()
        {
            new Cerveza() { Nombre = "Cristal", Marca = "Chela 1", Alcohol = 6, Cantidad = 23},
            new Cerveza() { Nombre = "Pilsen", Marca = "Chela 2", Alcohol = 5, Cantidad = 14},
            new Cerveza() { Nombre = "Cusqueña", Marca = "Chela 3", Alcohol = 6, Cantidad = 16},
        };

        public int GetCantidad(string Nombre)
        {
            var chela = (from d in chelas
                        where d.Nombre == Nombre
                        select d).FirstOrDefault();

            if(chela == null)
                throw new ChelaNoEncontrada("Ya no hay CHELAAAAAA");

            return chela.Cantidad;
        }
    }
}
