using FundamentosCSHARP.Models;
using System.Text.Json;

namespace FundamentoCSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Cerveza chela = new Cerveza(15, "Pilsen");
            string miJson = JsonSerializer.Serialize(chela);
            File.WriteAllText("objeto.txt", miJson);
            */

            string miJson2 = File.ReadAllText("objeto.txt");
            Cerveza chela = JsonSerializer.Deserialize<Cerveza>(miJson2);
            Console.WriteLine(chela.Nombre+" "+chela.Cantidad);

        }
    }
}
