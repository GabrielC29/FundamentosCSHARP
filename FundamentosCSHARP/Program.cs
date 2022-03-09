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
            var chela = new Cerveza() { Alcohol = 5, Marca = "Cerveza", Nombre = "Cristal", Cantidad = 22 };

            var post = new Post() { body = "cuerpazoooo", title = "titulo", userId = 22 };

            SendRequest<Post> service = new SendRequest<Post>();

            var cervezaRespuesta = await service.Send(post);

            Console.WriteLine(cervezaRespuesta.body+" "+cervezaRespuesta.id);
        }
    }
}
