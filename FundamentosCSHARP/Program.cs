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
            string url = "https://jsonplaceholder.typicode.com/posts/20"; //POST, DELETE, UPDATE
            string url2 = "https://jsonplaceholder.typicode.com/posts"; //GET

            HttpClient client = new HttpClient();

            Post post = new Post()
            {
                userId = 22,
                body = "Habla p loco",
                title = "Saludazo"
            };

            var data = JsonSerializer.Serialize<Post>(post);
            HttpContent content = new StringContent(data,System.Text.Encoding.UTF8,"application/json");

            var httpResponse = await client.PutAsync(url,content);

            var httpResponse2 = await client.GetAsync(url2);

            if (httpResponse.IsSuccessStatusCode)
            {
                var result = await httpResponse.Content.ReadAsStringAsync();

                var result2 = await httpResponse2.Content.ReadAsStringAsync();

                var postre = JsonSerializer.Deserialize<Post>(result);

                List<Post> posts = JsonSerializer.Deserialize<List<Post>>(result2);

                // var postResult = JsonSerializer.Deserialize<Post>(result);

                Console.WriteLine(postre.title);
            }

        }
    }
}
