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
            /* List<int> numeros = new List<int>() { 1, 2, 7, 4, 6, 3, 8, 5 };

            var numeroEnOrden = numeros.OrderBy(p => p);

            var Suma = numeros.Sum(p => p);

            foreach (var item in numeroEnOrden)
            {

                Console.WriteLine(item);

            }

            Console.WriteLine(Suma);*/

            List<Cerveza> chelas = new List<Cerveza>()
            {
                new Cerveza() { Nombre = "Cristal", Marca = "Chela 1", Alcohol = 6, Cantidad = 23},
                new Cerveza() { Nombre = "Pilsen", Marca = "Chela 2", Alcohol = 5, Cantidad = 14},
                new Cerveza() { Nombre = "Cusqueña", Marca = "Chela 3", Alcohol = 6, Cantidad = 16},
                new Cerveza() { Nombre = "Corona", Marca = "Chela 4", Alcohol = 4, Cantidad = 22}
            };

            var chelasOrdenadas = from p in chelas
                                  where p.Alcohol == 6 && p.Cantidad > 15
                                  orderby p.Nombre
                                  select p;

            foreach( var item in chelasOrdenadas)
            {
                Console.WriteLine($"{item.Nombre} {item.Marca}");
            }
        }
    }
}
