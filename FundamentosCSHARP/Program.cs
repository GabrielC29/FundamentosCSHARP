using FundamentosCSHARP.Models;
using FundamentosCSHARP.Service;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FundamentoCSHARP
{
    class Program
    {
        static async Task Main(string[] args)
        {

            List<Bar> bares = new List<Bar>()
            {
                new Bar("El bar number 1")
                {
                    chelas = new List<Cerveza>()
                    {
                        new Cerveza() { Nombre = "Cristal", Marca = "Chela 1", Alcohol = 6, Cantidad = 23},
                        new Cerveza() { Nombre = "Pilsen", Marca = "Chela 2", Alcohol = 5, Cantidad = 14},
                        new Cerveza() { Nombre = "Cusqueña", Marca = "Chela 3", Alcohol = 6, Cantidad = 16},
                    }
                },

                new Bar("Terrible bar 2")
                {
                    chelas = new List<Cerveza>()
                    {
                        new Cerveza() { Nombre = "Corona", Marca = "Chela 4", Alcohol = 4, Cantidad = 22},
                        new Cerveza() { Nombre = "Gabo", Marca = "Chela 5", Alcohol = 7, Cantidad = 17}
                    }
                },

                new Bar("Bar new")
            };

            var bar = (from p in bares
                      where p.chelas.Where(c => c.Cantidad >20).Count()>0
                      select new BarData(p.Nombre)
                      {
                          bebidas = (from c in p.chelas
                                      select new Bebida(c.Nombre,c.Cantidad)
                                      ).ToList()
                      }
                      ).ToList();

            Console.WriteLine(bar.Count);
        }
    }
}
