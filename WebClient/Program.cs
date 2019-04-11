using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WebClient
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            Console.ReadKey();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:5001/Api/v1/");
                var movieResponse = await client.GetAsync("movies/13");

                if (movieResponse.IsSuccessStatusCode)
                {
                    var movieObject = await movieResponse.Content.ReadAsAsync<MovieDataSource.Movie>();

                    Console.WriteLine(movieObject.Title);
                    Console.WriteLine(movieObject.Overview);
                }
                else
                    Console.WriteLine("Error Response");
            }

            Console.ReadKey();
        }
    }
}
