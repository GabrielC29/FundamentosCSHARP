using FundamentosCSHARP.Models;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FundamentoCSHARP
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string url = "https://jsonplaceholder.typicode.com/posts";
            HttpClient client = new HttpClient();

            var httpResponse = await client.GetAsync(url);

            if (httpResponse.IsSuccessStatusCode)
            {
                var json = await httpResponse.Content.ReadAsStringAsync();
                List<Post> post = JsonSerializer.Deserialize<List<Post>>(json);

                foreach(var item in post)
                {
                    Console.WriteLine("id: "+item.id+"\n title: "+item.title+"\n body: "+item.body+"\n ");
                }

            }

        }
    }
}
